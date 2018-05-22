/**
 * Autogenerated by Thrift Compiler (1.0.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;

namespace Evernote.EDAM.UserStore
{
  public static class UserStoreConstants
  {
    /// <summary>
    /// The major version number for the current revision of the EDAM protocol.
    /// Clients pass this to the service using UserStore.checkVersion at the
    /// beginning of a session to confirm that they are not out of date.
    /// </summary>
    public const short EDAM_VERSION_MAJOR = 1;
    /// <summary>
    /// The minor version number for the current revision of the EDAM protocol.
    /// Clients pass this to the service using UserStore.checkVersion at the
    /// beginning of a session to confirm that they are not out of date.
    /// </summary>
    public const short EDAM_VERSION_MINOR = 28;
  }
}
