
using Lesson8_02_03;

Point taskas = new Point(10, 10);
Point virsusKaire = new Point(0, 0);
Point apaciaDesine = new Point(10, 10);
Rectangle staciakampis = new Rectangle(virsusKaire, apaciaDesine);
Console.WriteLine(staciakampis.IsPointInRectangle(taskas));