﻿using Google.Protobuf;
using System;
using UnityEngine;

public static class Utils {

    public static byte[] String2Byte( string str ) {
        return System.Text.Encoding.UTF8.GetBytes( str );
    }

    public static string Byte2String( byte[] bytes ) {
        return System.Text.Encoding.UTF8.GetString( bytes );
    }

    public static long GetTimeStamp() {
        var utcNow = DateTime.UtcNow;
        var timeSpan = utcNow - new DateTime( 1970, 1, 1, 0, 0, 0 );
        return (long)timeSpan.TotalSeconds;
    }

    static public T GetOrAddComponent<T>( this Component self ) where T : Component {
        T result = self.GetComponent<T>();
        if( result == null ) {
            result = self.gameObject.AddComponent<T>();
        }
        return result;
    }

    static public T GetOrAddComponent<T>( this GameObject self ) where T : Component {
        T result = self.GetComponent<T>();
        if( result == null ) {
            result = self.gameObject.AddComponent<T>();
        }
        return result;
    }

    public static T ParseByte<T>( byte[] data ) where T : IMessage, new() {
        IMessage imPack = new T();
        T pkg = new T();
        pkg = (T)imPack.Descriptor.Parser.ParseFrom( data );
        return pkg;
    }

}