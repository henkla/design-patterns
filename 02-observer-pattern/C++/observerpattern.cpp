#include "pch.h"
#include <iostream>
#include "Subject.cpp"

using namespace std;

int main()
{
	// Create the subject
	cout << "1: Creating subject...\n";
	Subject s = Subject();
	
	// Pretend somethind happened in the subject
	// and notify all observers
	cout << "2: Notifying all registered observers...\n";
	s.NotifyObservers();

	// Create one observer and register at subject
	cout << "3: Creating observer Bosse...\n";
	Observer o1 = Observer("Bosse");
	cout << "4: Registering Bosse at Subject...\n";
	s.AttachObserver(&o1);

	// Pretend somethind happened in the subject
	// and notify all observers
	cout << "5: Notifying all registered observers...\n";
	s.NotifyObservers();

	// Create two more observers and register at subject 
	cout << "6: Creating observer Kjelle...\n";
	Observer o2 = Observer("Kjelle");
	cout << "7: Registering Kjelle at Subject...\n";
	s.AttachObserver(&o2);
	cout << "8: Creating observer Ronny...\n";
	Observer o3 = Observer("Ronny");
	cout << "9: Registering Ronny at Subject...\n";
	s.AttachObserver(&o3);

	// Pretend somethind happened in the subject
	// and notify all observers
	cout << "10: Notifying all registered observers...\n";
	s.NotifyObservers();

	cout << "11: Unregistering all observers...\n";
	s.DetachObserver(&o1);
	s.DetachObserver(&o2);
	s.DetachObserver(&o3);

	// Pretend somethind happened in the subject
	// and notify all observers
	cout << "12: Notifying all registered observers...\n";
	s.NotifyObservers();
}