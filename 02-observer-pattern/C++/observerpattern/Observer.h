#pragma once
class Observer
{
public:
	string _name = "foo";
	
	Observer(string name);
	~Observer();

	void Update();
};

