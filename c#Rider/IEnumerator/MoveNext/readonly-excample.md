````csharp

 

public class HorizontalMatrixEnumerator : IEnumerator<double>
{
private readonly double[,] _matrix;
private readonly int _rowLength;
private int _colIndex;
private int _rowIndex;
private double _curItem;

    public HorizontalMatrixEnumerator(double[,] matrix)
    {
        _matrix = matrix;
        _rowLength = matrix.GetLength(0);
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
        if (_colIndex == _matrix.GetLength(1) && _rowIndex == _rowLength)
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
private readonly double[,] _matrix;
private readonly int _colLength;
private int _colIndex;
private int _rowIndex;
private double _curItem;

    public VerticalMatrixEnumerator(double[,] matrix)
    {
        _matrix = matrix;
        _colLength = matrix.GetLength(1);
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
        if (_colIndex == _colLength && _rowIndex == _matrix.GetLength(0))
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
````