/**
 * Autogenerated by Thrift Compiler (1.0.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

namespace Evernote.EDAM.Type
{
  /// <summary>
  /// This enumeration defines the possible ways to access related content.
  /// 
  /// NOT_ACCESSIBLE: The content is not accessible given the user's privilege level, but
  ///     still worth showing as a snippet. The content url may point to a webpage that
  ///     explains why not, or explains how to access that content.
  /// 
  /// DIRECT_LINK_ACCESS_OK: The content is accessible directly, and no additional login is
  ///     required.
  /// 
  /// DIRECT_LINK_LOGIN_REQUIRED: The content is accessible directly, but an additional login
  ///     is required.
  /// 
  /// DIRECT_LINK_EMBEDDED_VIEW: The content is accessible directly, and should be shown in
  ///     an embedded web view.
  ///     If the URL refers to a secured location under our control (for example,
  ///     https://www.evernote.com/*), the client may include user-specific authentication
  ///     credentials with the request.
  /// </summary>
  public enum RelatedContentAccess
  {
    NOT_ACCESSIBLE = 0,
    DIRECT_LINK_ACCESS_OK = 1,
    DIRECT_LINK_LOGIN_REQUIRED = 2,
    DIRECT_LINK_EMBEDDED_VIEW = 3,
  }
}