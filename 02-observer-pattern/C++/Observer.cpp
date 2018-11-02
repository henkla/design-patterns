
#include "pch.h"
#include <iostream>
#include <string>

using namespace std;
class Observer {

	std::string _name;

public:
	Observer(std::string name)
	{
		this->_name = name;
	}

	~Observer()
	{
	}

	void Update() {
		cout << "- " + this->_name + " was notified and updated.\n";
	}
};

