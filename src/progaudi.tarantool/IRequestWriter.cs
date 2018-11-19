﻿using System;
using System.Buffers;

namespace ProGaudi.Tarantool.Client
{
    internal interface IRequestWriter : IDisposable
    {
        void BeginWriting();

        bool IsConnected { get; }

        void Write(ReadOnlyMemory<byte> package);
    }
}