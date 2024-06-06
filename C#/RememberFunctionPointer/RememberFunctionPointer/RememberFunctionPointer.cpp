#include <iostream>

using namespace std;

class Person {
public:
	string name;
	int age;
	Person(string n, int a) {
		name = n;
		age = a;
	}
};

bool compare(Person left, Person right) {
	return left.age > right.age;
}

template<typename T>
void sort(T* arr, size_t size, bool(*func)(T, T)) {
	for (size_t i = 0; i < size - 1; i++)
	{
		for (size_t j = 0; j < size - 1; j++)
		{
			if (func(arr[j], arr[j + 1]))
				swap(arr[j], arr[j + 1]);
		}
	}
}

bool com(Person p, Person p1) {
	return p.name > p1.name;
}

int main()
{
	//int size = 10;
	//double* arr = new double[size] {1, 2, 57, 6575, 2, 4312, 43, 46, 3, 21};
	//sort(arr, size, true);

	//for (size_t i = 0; i < size; i++)
	//{
	//	cout << arr[i] << " ";
	//}

	//Person* people = new Person[5]{
	//	Person("kamil", 12),
	//	Person("hakuna", 42),
	//	Person("matata", 2),
	//	Person("fazir", 89),
	//	Person("nazim", 23),
	//};

	//sort(people, 5, com);

	//for (size_t i = 0; i < 5; i++)
	//{
	//	cout << people[i].name << " ";
	//}
	//cout << com;

	//bool(*f)(Person, Person) = com;
	//f = compare;

	

}
