
using TypeOfLinerSearch;


double[] X = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
double[] Y = { 3345.678, 762.23, 67.5, 125, 200.23, 99.45, 90.21, 221, 400, 777, 700, 40, 34.33, 3345.678, 762.23, 67.5, 125, 200.23, 99.45, 90.21 };

Searcher searcher = new Searcher();
StepPrice stepPrice = new StepPrice();
LevelPrice levelPrice = new LevelPrice();

List<(double,double,string)> getx =  searcher.GetExtremums(X,Y,10,20);
//stepPrice.GetStep(getx);
//levelPrice.GetLevelPrice(getx);


Console.ReadKey(); 