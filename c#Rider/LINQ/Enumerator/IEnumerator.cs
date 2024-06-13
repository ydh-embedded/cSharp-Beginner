﻿// IEnumerator.cs
namespace Enumerator;

public interface IEnumerator<T>
{
    T Current { get; }
    bool MoveNext();
    void Reset();
}