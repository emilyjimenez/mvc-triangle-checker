namespace TriangleChecker.Models
{
  public class Triangle
  {
    private int _sideOne;
    private int _sideTwo;
    private int _sideThree;

    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
      _sideOne = sideOne;
      _sideTwo = sideTwo;
      _sideThree = sideThree;
    }

    public int GetSideOne()
    {
      return _sideOne;
    }
    public void SetSideOne(int newSideOne)
    {
      _sideOne = newSideOne;
    }

    public int GetSideTwo()
    {
      return _sideTwo;
    }
    public void SetSideTwo(int newSideTwo)
    {
      _sideTwo = newSideTwo;
    }

    public int GetSideThree()
    {
      return _sideThree;
    }
    public void SetSideThree(int newSideThree)
    {
      _sideThree = newSideThree;
    }

    public bool CheckIsTriangle()
    {
      if (_sideOne == 0 | _sideTwo == 0 | _sideThree == 0)
      {
        return false;
      }
      else if (_sideOne + _sideTwo < _sideThree)
      {
        return false;
      }
      else if (_sideOne + _sideThree < _sideTwo)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    public bool CheckIsEquilateral()
    {
      if (_sideOne == _sideTwo & _sideTwo == _sideThree)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool CheckIsIsosceles()
    {
      if (_sideOne == _sideTwo & _sideTwo != _sideThree)
      {
        return true;
      }
      else if (_sideOne == _sideThree & _sideTwo != _sideThree)
      {
        return true;
      }
      else if (_sideTwo == _sideThree & _sideOne != _sideThree)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
