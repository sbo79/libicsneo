#ifndef __PACKETIZER_H_
#define __PACKETIZER_H_

#include "communication/include/packet.h"
#include <queue>
#include <vector>
#include <memory>

namespace icsneo {

class Packetizer {
public:
	static uint8_t ICSChecksum(const std::vector<uint8_t>& data);
	std::vector<uint8_t>& packetWrap(std::vector<uint8_t>& data, bool shortFormat);

	bool input(const std::vector<uint8_t>& bytes);
	std::vector<std::shared_ptr<Packet>> output();

	bool disableChecksum = false; // Even for short packets
	bool align16bit = true; // Not needed for Gigalog, Galaxy, etc and newer
	
private:
	enum class ReadState {
		SearchForHeader,
		ParseHeader,
		ParseLongStylePacketHeader,
		GetData
	};
	ReadState state = ReadState::SearchForHeader;

	int currentIndex = 0;
	int packetLength = 0;
	int headerSize = 0;
	bool checksum = false;
	bool gotGoodPackets = false; // Tracks whether we've ever gotten a good packet
	Packet packet;
	std::deque<uint8_t> bytes;

	std::vector<std::shared_ptr<Packet>> processedPackets;
};

}

#endif