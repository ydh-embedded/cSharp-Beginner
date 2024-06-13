using System;
using System.Collections;
using System.Collections.Generic;

public abstract class Program
{
    static void Main()
    {
        double[,] matrix = new double[3, 2]
        {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 }
        };

        ByEnumerator enumerator = new ByEnumerator(matrix);

        IEnumerator<double> horizontalEnumerator = enumerator.HorizontalEnumerator();
        while (horizontalEnumerator.MoveNext())
        {
            Console.WriteLine(horizontalEnumerator.Current);
        }

        IEnumerator<double> verticalEnumerator = enumerator.VerticalEnumerator();
        while (verticalEnumerator.MoveNext())
        {
            Console.WriteLine(verticalEnumerator.Current);
        }
    }
}

public class ByEnumerator : IEnumerable<double>
{
    private double[,] _matrix;

    public ByEnumerator(double[,] matrix)
    {
        _matrix = matrix;
    }

    public IEnumerator<double> GetEnumerator()
    {
        return new HorizontalMatrixEnumerator(_matrix);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<double> HorizontalEnumerator()
    {
        return new HorizontalMatrixEnumerator(_matrix);
    }

    public IEnumerator<double> VerticalEnumerator()
    {
        return new VerticalMatrixEnumerator(_matrix);
    }
}

public class HorizontalMatrixEnumerator : IEnumerator<double>
{
    private double[,] _matrix;
    private int _colIndex;
    private int _rowIndex;
    private double _curItem;

    public HorizontalMatrixEnumerator(double[,] matrix)
    {
        _matrix = matrix;
        Reset();
    }

    public double Current
    {
        get { return _curItem; }
    }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        // Not implemented
    }

    public bool MoveNext()
    {
        if (_colIndex == _matrix.GetLength(1) && _rowIndex == _matrix.GetLength(0))
        {
            return false;
        }
        if (_colIndex == _matrix.GetLength(1))
        {
            _colIndex = 0;
            _rowIndex += 1;
        }
        else
        {
            _colIndex += 1;
        }
        _curItem = _matrix[_rowIndex, _colIndex];
        return true;
    }

    public void Reset()
    {
        _colIndex = -1;
        _rowIndex = 0;
        _curItem = double.NaN;
    }
}

public class VerticalMatrixEnumerator : IEnumerator<double>
{
    private double[,] _matrix;
    private int _colIndex;
    private int _rowIndex;
    private double _curItem;

    public VerticalMatrixEnumerator(double[,] matrix)
    {
        _matrix = matrix;
        Reset();
    }

    public double Current
    {
        get { return _curItem; }
    }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        // Not implemented
    }

    public bool MoveNext()
    {
        if (_colIndex == _matrix.GetLength(1) && _rowIndex == _matrix.GetLength(0))
        {
            return false;
        }
        if (_rowIndex == _matrix.GetLength(0))
        {
            _rowIndex = 0;
            _colIndex += 1;
        }
        else
        {
            _rowIndex += 1;
        }
        _curItem = _matrix[_rowIndex, _colIndex];
        return true;
    }

    public void Reset()
    {
        _colIndex = 0;
        _rowIndex = -1;
        _curItem = double.NaN;
    }
}