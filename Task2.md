# Задание №2 Code Review
```
private IPlaceService PlaceService = null!;
private ISailDb SailDb = null;
private IPassengersDb PassengersDb = null;
```
Не уверен, что в данном фрагменте стоит определять значения атрибутов класса как null. Я бы оставио их неопределёнными для того, чтобы не происходил доступ по нулевой ссылке.

```
Captain = p;
VoyageId = id;
```
Хотелось бы видеть более подробные и понятные имена параметров функций, вроде "captain" и "voyageId". Это замечание актуально и в дальнейшем.

```
public void ChangeCaptain(string fn, string ln, string doc)
   {
       Captain.FirstName = fn;
       Captain.LastName = ln;
   }
```
Непонятно, зачем метод ChangeCapitain принимает неиспользуемый параметр doc.