#pragma once
class Subject
{

public:
	Subject();
	~Subject();
	void AttachObserver(Observer* o);
	void DetachObserver(Observer* o);
	void NotifyObservers();
};

