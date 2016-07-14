RawQuery
===========

A simple raw sql constructor.

Sometimes there's a need to build complex dynamic sql queries and this is quite hard to do via ORM like EntityFramework or so on.
This library just provides an ability to do such things with less pain.

Here's an example how to write a simple pivot query:

```cs
///Just some input data. Can be replaced with a real table select.
var income =
    Union.All(
        Clause.Select(
            Format.List(
                Clause.As(To.Number(1), "Day"),
                Clause.As(To.Number(15.9), "Income"),
                Clause.As(To.String("w1"), "Worker"))),
        Clause.Select(
            Format.List(
                Clause.As(To.Number(1), "Day"),
                Clause.As(To.Number(17.2), "Income"),
                Clause.As(To.String("w2"), "Worker"))),
        Clause.Select(
            Format.List(
                Clause.As(To.Number(2), "Day"),
                Clause.As(To.Number(10.1), "Income"),
                Clause.As(To.String("w1"), "Worker"))),
        Clause.Select(
            Format.List(
                Clause.As(To.Number(3), "Day"),
                Clause.As(To.Number(21), "Income"),
                Clause.As(To.String("w2"), "Worker"))),
        Clause.Select(
            Format.List(
                Clause.As(To.Number(4), "Day"),
                Clause.As(To.Number(8.3), "Income"),
                Clause.As(To.String("w3"), "Worker"))),
        Clause.Select(
            Format.List(
                Clause.As(To.Number(5), "Day"),
                Clause.As(To.Number(-1.2), "Income"),
                Clause.As(To.String("w2"), "Worker"))),
        Clause.Select(
            Format.List(
                Clause.As(To.Number(5), "Day"),
                Clause.As(To.Number(6.3), "Income"),
                Clause.As(To.String("w2"), "Worker"))));

//Let's make a simple pivot to look at workers' income by days.
var sql =
    Clause.Pivot(
        Clause.Select(
            Format.List(
                "Worker",
                Clause.As("[1]", "[Day 1]"),
                Clause.As("[2]", "[Day 2]"),
                Clause.As("[3]", "[Day 3]"),
                Clause.As("[4]", "[Day 4]"),
                Clause.As("[5]", "[Day 5]")),
            Clause.As(Brackets.Round(income), "inc")),
        Format.Multiline(
            Func.Sum("Income"),
            Logical.ForIn("Day", Format.List("[1]", "[2]", "[3]", "[4]", "[5]"))),
        "pvt");

//Perform query and print the output.
//It may vary for different ORM and other libraries that support raw queries.
using (var connection = new SqlConnection(connectionStirng))
{
    using (var command = new SqlCommand(sql, connection))
    {
        connection.Open();
        using (var reader = command.ExecuteReader())
        {
            for (var i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i));
                Console.Write("\t");
            }
            Console.WriteLine();

            while (reader.Read())
            {
                for (var i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write(reader[i]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
```

The outcome will be:
```
Worker  Day 1   Day 2   Day 3   Day 4   Day 5
w1      15.9    10.1
w2      17.2            21.0            5.1
w3                              8.3
```