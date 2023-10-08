
DayTemperature temp1= new DayTemperature(29.6m, 24.1m);
DayTemperature temp2 = new DayTemperature(25.6m, 24.1m);

Console.WriteLine(temp1 + "\n" + temp2);

Console.WriteLine(temp1!=temp2);
Console.WriteLine(temp1.Average);

DayTemperature temp3 = temp1 with { High = 20.0m };
Console.WriteLine(temp3);

public record DayTemperature(decimal High, decimal Low)
{
    public decimal Average
    {
        get => (High + Low) / 2;
    }
}























//float x = 23.0f;
//string str= x.ToString();
//Console.WriteLine(str);

//Person p= new Person() { FirstName = "Shaz", LastName = "Rasheed", Age = 23 };
//Person p1 = new Person() { FirstName = "Shaz", LastName = "Rasheed", Age = 23 };
//Console.WriteLine($"{p}");
//Console.WriteLine($"{p.Equals(p1)}");
//Console.WriteLine($"{p==p1}");
//Console.WriteLine($"{p != p1}");

//public class Person
//{
//    public string? FirstName;
//    public string? LastName;
//    public int Age;

//    public override string ToString()=>$"[Person] FirstName:{FirstName}, LastName:{LastName}, Age:{Age}";
//    public override bool Equals(object? obj) => Equals(obj as Person);
   
//    public bool Equals(Person? p)=>p!=null && (FirstName==p.FirstName && LastName==p.LastName);

//    public override int GetHashCode() => (FirstName,LastName).GetHashCode();

//    public static bool operator ==(Person p, Person p1)
//    {
//        if(p is null)
//        {
//            if(p1 is null)
//            {
//                return true;
//            }
//            return false;
            
//        }
//        return p.Equals(p1);
//    }

//    public static bool operator !=(Person p, Person p1) =>
//        !(p == p1);
//}









//SecuritiesTrade[] tradeList = new SecuritiesTrade[]
//{
//    new StockTrade(){Symbol="ABCD",Quantity=1200,Price=27.81m},
//    new BondTrade(){Name="Qwert 50yr",Duration=5,Price=50.0m,Quantity=10},
//};

//foreach (var tradeItem in tradeList)
//{
//    try
//    {
//        CommisionCalculator.PrintTradeCommission(tradeItem);
//    }
//    catch(ArgumentException e) { 
//        Console.WriteLine(e.Message);
//    }
//}













//void FirstOrSecondHalfOfYear(object dt)
//{
//    if(dt is DateTime { Month: > 6 })
//    {
//        Console.WriteLine("Date is in Second Half");
//    }
//    else
//    {
//        Console.WriteLine("Date is in First Half");
//    }
//}

//DateTime[] dates = new[]
//{
//    new DateTime(2023,5,3),
//    new DateTime(2023,7,6)
//};

//foreach (DateTime differentDates in dates)
//{
//    FirstOrSecondHalfOfYear(differentDates);
//}















//string Classify(Point point) => point switch
//{
//    ( > 0, > 0) => "Upper right quadrant",
//    ( < 0, > 0) => "Upper left quadrant",
//    ( > 0, < 0) => "Lower right quadrant",
//    ( < 0, < 0) => "Lower left quadrant",
//    _ => "Just a point"
//};



//Point[] TestPointData = new[]
//{
//    new Point(5,8),
//    new Point(-2,7),
//    new Point(1,-1)
//};

//foreach (Point point in TestPointData)
//{
//    Console.WriteLine($"Point is {Classify(point)}");
//}


//public readonly struct Point
//{
//    public int X { get; }
//    public int Y { get; }   
//    public Point(int x,int y)=> (X,Y)=(x,y);
//    public void Deconstruct(out int x, out int y)=>(x,y)=(X,Y);

//}














//decimal GetGroupTicketPriceDiscount(int groupSize, DateTime visitDate) => (groupSize, visitDate.DayOfWeek) switch
//{
//    (_, DayOfWeek.Saturday or DayOfWeek.Sunday) => 0.0m,
//    ( >= 5 and < 10, DayOfWeek.Monday) => 0.20m,
//    ( >= 10, DayOfWeek.Monday) => 0.30m,
//    ( >= 10, _) => 0.15m,
//    ( <= 0, _) => throw new ArgumentException("Group Size must be +ve number"),
//    _ => 0.0m
//};

//(int, DateTime)[] TestDiscountData = new[]
//{
//    (4, new DateTime(2022,9,3)),
//    (5, new DateTime(2023,10,9))
//};

//foreach ((var size, var date) in TestDiscountData)
//{
//    decimal discount = GetGroupTicketPriceDiscount(size,date);
//    Console.WriteLine($"Discount for {size} person group on {date: y,MMM,d} is {discount}");
//}







//string ShapeToString(object shape) => shape switch
//{
//    Circle { Radius: var r } when r > 10 => " Big Circle",
//    Circle { Radius: var r } when r <= 10 => " Little Circle",
//    Triangle => "Triangle",
//    Rectangle { Length: var l, Width: var w } when l == w => "Square",
//    Rectangle => "Rectangle",
//    _ => "Unknown"
//}; ;

//Console.WriteLine(ShapeToString(new Rectangle {Length=5, Width=5 }));






























//string[] words = new string[]
//{
//    "The","Hero", "was", "Hulk","not","Thor"
//};

//Console.WriteLine(words[^2]);
//string[] wordRange = words[2..5];
//Console.WriteLine($"{string.Join(",", wordRange)}");
//wordRange = words[..5];
//Console.WriteLine($"{string.Join(",", wordRange)}");
//wordRange = words[2..];
//Console.WriteLine($"{string.Join(",", wordRange)}");
//wordRange = words[..];
//Console.WriteLine($"{string.Join(",", wordRange)}");

//Index idx = ^4;
//Console.WriteLine(words[idx]);
//Range range = ..^2;
//wordRange = words[range];
//Console.WriteLine($"{string.Join(",", wordRange)}");

//void ThrowableLogString(string? theString)
//{
//    Console.WriteLine(theString ?? throw new ArgumentNullException("theString", "Cannot be Null"));
//}
//ThrowableLogString(null);

//string? str = "This is it";
//string num1 = "5";
//int number;
//if(int.TryParse(num1,out number))
//{
//    Console.WriteLine(number);
//}

//bool IsTheIdesOfMarch(DateTime date)
//{
//    return (date is { Month: 3, Day: 14 or 15 });
//}

//Console.WriteLine(IsTheIdesOfMarch(new DateTime(DateTime.Today.Year, 1, 13)));

//Console.WriteLine(IsTheIdesOfMarch(new DateTime(DateTime.Today.Year, 3, 14)));

//Console.WriteLine(IsTheIdesOfMarch(new DateTime(DateTime.Today.Year, 3, 15)));

//Console.WriteLine(DateTime.Today.DayOfWeek);



