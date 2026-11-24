namespace APIcalculator.DTO
{
    public class TwoNumbersDto
{
    public double Num1 { get; set; }
    public double Num2 { get; set; }
}

public class CalcResponseDto
{
    public string Operation { get; set; }
    public double Result { get; set; }
}
}
