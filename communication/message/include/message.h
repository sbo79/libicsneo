#ifndef __MESSAGE_H_
#define __MESSAGE_H_

#include "communication/include/network.h"
#include <vector>

namespace icsneo {

class Message {
public:
	virtual ~Message() {}
	Network network;
	std::vector<uint8_t> data;
};

};

#endif