#include "pch.h"
#include <vector>
#include <algorithm>
#include "Observer.cpp"
	
using namespace std;
class Subject 
{

public:
	vector<Observer*> observers;

	Subject()
	{
	}

	~Subject()
	{
	}

	void AttachObserver(Observer* o)
	{
		observers.push_back(o);
	}

	void DetachObserver(Observer* o)
	{
		observers.erase(std::remove(observers.begin(), observers.end(), o), observers.end());
	}

	void NotifyObservers()
	{
		for (std::vector<Observer*>::iterator it = observers.begin(); it != observers.end(); ++it) {
			(**it).Update();
		}
	}
};
