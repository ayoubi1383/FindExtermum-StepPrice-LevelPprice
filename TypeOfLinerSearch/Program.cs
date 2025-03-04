
using TypeOfLinerSearch;


double[] X = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 33 };
double[] Y = { 3345.678, 762.23, 67.5, 125, 200.23, 99.45, 90.21, 221, 400, 777, 700, 40, 34.33 };

Searcher searcher = new Searcher();
StepPrice stepPrice = new StepPrice();
LevelPrice levelPrice = new LevelPrice();

List<(double,double,string)> getx =  searcher.GetExtremums(X,Y);
//stepPrice.GetStep(getx);
levelPrice.GetLevelPrice(getx);


Console.ReadKey(); 