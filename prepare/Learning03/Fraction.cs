using System;

public class Fraction
{
    private string _topNum;
    private string _bottomNum;

    // Constructors
    public Fraction()
    {
        _topNum = "1";
        _bottomNum = "1";
    }

    public Fraction(string top)
    {
        _topNum = top;
        _bottomNum = "1";
    }

    public Fraction(string top, string bottom)
    {
        _topNum = top;
        _bottomNum = bottom;
    }

    // Getters and setters
    public string GetTopNum() 
    {
        return _topNum;
    }

    public void SetTopNum(string topNum)
    {
        _topNum = topNum;
    }

    public string GetBottomNum()
    {
        return _bottomNum;
    }

    public void SetBottomNum(string bottomNum)
    {
        _bottomNum = bottomNum;
    }

    public string GetFractionString()
    {
        return $"{_topNum}/{_bottomNum}";
        //Console.WriteLine($"{_topNum}/{_bottomNum}");
    }

    public double GetDecimalValue()
    {
        double top = Convert.ToDouble(_topNum);
        double bottom = Convert.ToDouble(_bottomNum);
        return top/bottom;
    }

}