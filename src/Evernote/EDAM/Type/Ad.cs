/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Evernote.EDAM.Type
{

  #if !SILVERLIGHT && !NETFX_CORE
  [Serializable]
  #endif
  public partial class Ad : TBase
  {
    private int _id;
    private short _width;
    private short _height;
    private string _advertiserName;
    private string _imageUrl;
    private string _destinationUrl;
    private short _displaySeconds;
    private double _score;
    private byte[] _image;
    private string _imageMime;
    private string _html;
    private double _displayFrequency;
    private bool _openInTrunk;

    public int Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public short Width
    {
      get
      {
        return _width;
      }
      set
      {
        __isset.width = true;
        this._width = value;
      }
    }

    public short Height
    {
      get
      {
        return _height;
      }
      set
      {
        __isset.height = true;
        this._height = value;
      }
    }

    public string AdvertiserName
    {
      get
      {
        return _advertiserName;
      }
      set
      {
        __isset.advertiserName = true;
        this._advertiserName = value;
      }
    }

    public string ImageUrl
    {
      get
      {
        return _imageUrl;
      }
      set
      {
        __isset.imageUrl = true;
        this._imageUrl = value;
      }
    }

    public string DestinationUrl
    {
      get
      {
        return _destinationUrl;
      }
      set
      {
        __isset.destinationUrl = true;
        this._destinationUrl = value;
      }
    }

    public short DisplaySeconds
    {
      get
      {
        return _displaySeconds;
      }
      set
      {
        __isset.displaySeconds = true;
        this._displaySeconds = value;
      }
    }

    public double Score
    {
      get
      {
        return _score;
      }
      set
      {
        __isset.score = true;
        this._score = value;
      }
    }

    public byte[] Image
    {
      get
      {
        return _image;
      }
      set
      {
        __isset.image = true;
        this._image = value;
      }
    }

    public string ImageMime
    {
      get
      {
        return _imageMime;
      }
      set
      {
        __isset.imageMime = true;
        this._imageMime = value;
      }
    }

    public string Html
    {
      get
      {
        return _html;
      }
      set
      {
        __isset.html = true;
        this._html = value;
      }
    }

    public double DisplayFrequency
    {
      get
      {
        return _displayFrequency;
      }
      set
      {
        __isset.displayFrequency = true;
        this._displayFrequency = value;
      }
    }

    public bool OpenInTrunk
    {
      get
      {
        return _openInTrunk;
      }
      set
      {
        __isset.openInTrunk = true;
        this._openInTrunk = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT && !NETFX_CORE
    [Serializable]
    #endif
    public struct Isset {
      public bool id;
      public bool width;
      public bool height;
      public bool advertiserName;
      public bool imageUrl;
      public bool destinationUrl;
      public bool displaySeconds;
      public bool score;
      public bool image;
      public bool imageMime;
      public bool html;
      public bool displayFrequency;
      public bool openInTrunk;
    }

    public Ad() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I32) {
              Id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I16) {
              Width = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I16) {
              Height = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              AdvertiserName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              ImageUrl = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              DestinationUrl = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I16) {
              DisplaySeconds = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Double) {
              Score = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.String) {
              Image = iprot.ReadBinary();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.String) {
              ImageMime = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.String) {
              Html = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.Double) {
              DisplayFrequency = iprot.ReadDouble();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.Bool) {
              OpenInTrunk = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("Ad");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.id) {
        field.Name = "id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Id);
        oprot.WriteFieldEnd();
      }
      if (__isset.width) {
        field.Name = "width";
        field.Type = TType.I16;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Width);
        oprot.WriteFieldEnd();
      }
      if (__isset.height) {
        field.Name = "height";
        field.Type = TType.I16;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Height);
        oprot.WriteFieldEnd();
      }
      if (AdvertiserName != null && __isset.advertiserName) {
        field.Name = "advertiserName";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(AdvertiserName);
        oprot.WriteFieldEnd();
      }
      if (ImageUrl != null && __isset.imageUrl) {
        field.Name = "imageUrl";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ImageUrl);
        oprot.WriteFieldEnd();
      }
      if (DestinationUrl != null && __isset.destinationUrl) {
        field.Name = "destinationUrl";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DestinationUrl);
        oprot.WriteFieldEnd();
      }
      if (__isset.displaySeconds) {
        field.Name = "displaySeconds";
        field.Type = TType.I16;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(DisplaySeconds);
        oprot.WriteFieldEnd();
      }
      if (__isset.score) {
        field.Name = "score";
        field.Type = TType.Double;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Score);
        oprot.WriteFieldEnd();
      }
      if (Image != null && __isset.image) {
        field.Name = "image";
        field.Type = TType.String;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(Image);
        oprot.WriteFieldEnd();
      }
      if (ImageMime != null && __isset.imageMime) {
        field.Name = "imageMime";
        field.Type = TType.String;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ImageMime);
        oprot.WriteFieldEnd();
      }
      if (Html != null && __isset.html) {
        field.Name = "html";
        field.Type = TType.String;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Html);
        oprot.WriteFieldEnd();
      }
      if (__isset.displayFrequency) {
        field.Name = "displayFrequency";
        field.Type = TType.Double;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(DisplayFrequency);
        oprot.WriteFieldEnd();
      }
      if (__isset.openInTrunk) {
        field.Name = "openInTrunk";
        field.Type = TType.Bool;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(OpenInTrunk);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Ad(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",Width: ");
      sb.Append(Width);
      sb.Append(",Height: ");
      sb.Append(Height);
      sb.Append(",AdvertiserName: ");
      sb.Append(AdvertiserName);
      sb.Append(",ImageUrl: ");
      sb.Append(ImageUrl);
      sb.Append(",DestinationUrl: ");
      sb.Append(DestinationUrl);
      sb.Append(",DisplaySeconds: ");
      sb.Append(DisplaySeconds);
      sb.Append(",Score: ");
      sb.Append(Score);
      sb.Append(",Image: ");
      sb.Append(Image);
      sb.Append(",ImageMime: ");
      sb.Append(ImageMime);
      sb.Append(",Html: ");
      sb.Append(Html);
      sb.Append(",DisplayFrequency: ");
      sb.Append(DisplayFrequency);
      sb.Append(",OpenInTrunk: ");
      sb.Append(OpenInTrunk);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
