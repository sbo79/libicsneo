//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class neoevent_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal neoevent_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(neoevent_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~neoevent_t() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          icsneocsharpPINVOKE.delete_neoevent_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string description {
    set {
      icsneocsharpPINVOKE.neoevent_t_description_set(swigCPtr, value);
    }
    get {
      string ret = icsneocsharpPINVOKE.neoevent_t_description_get(swigCPtr);
      return ret;
    }
  }

  public SWIGTYPE_p_time_t timestamp {
    set {
      icsneocsharpPINVOKE.neoevent_t_timestamp_set(swigCPtr, SWIGTYPE_p_time_t.getCPtr(value));
      if (icsneocsharpPINVOKE.SWIGPendingException.Pending) throw icsneocsharpPINVOKE.SWIGPendingException.Retrieve();
    }
    get {
      SWIGTYPE_p_time_t ret = new SWIGTYPE_p_time_t(icsneocsharpPINVOKE.neoevent_t_timestamp_get(swigCPtr), true);
      if (icsneocsharpPINVOKE.SWIGPendingException.Pending) throw icsneocsharpPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  }

  public uint eventNumber {
    set {
      icsneocsharpPINVOKE.neoevent_t_eventNumber_set(swigCPtr, value);
    }
    get {
      uint ret = icsneocsharpPINVOKE.neoevent_t_eventNumber_get(swigCPtr);
      return ret;
    }
  }

  public byte severity {
    set {
      icsneocsharpPINVOKE.neoevent_t_severity_set(swigCPtr, value);
    }
    get {
      byte ret = icsneocsharpPINVOKE.neoevent_t_severity_get(swigCPtr);
      return ret;
    }
  }

  public string serial {
    set {
      icsneocsharpPINVOKE.neoevent_t_serial_set(swigCPtr, value);
    }
    get {
      string ret = icsneocsharpPINVOKE.neoevent_t_serial_get(swigCPtr);
      return ret;
    }
  }

  public SWIGTYPE_p_unsigned_char reserved {
    set {
      icsneocsharpPINVOKE.neoevent_t_reserved_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    }
    get {
      global::System.IntPtr cPtr = icsneocsharpPINVOKE.neoevent_t_reserved_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    }
  }

  public neoevent_t() : this(icsneocsharpPINVOKE.new_neoevent_t(), true) {
  }

}
