using System.Collections;

namespace MoveNext;

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
        if (_colIndex == _matrix.GetLength(1) & _rowIndex == _matrix.GetLength(0))
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