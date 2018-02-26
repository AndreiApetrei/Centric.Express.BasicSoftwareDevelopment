In this repo there are two GildedRose kata implementations:

- The first one is done with the same approach we used during the course: using multiple classes and inheritance to encapsulate the specific item behaviours.
  As I mentioned during the course, I wasn't able to make the code SOLID using this approach. Notice how LegendaryItem is not really a ShelveItem, even though it inherits it (as UpdateItemQuality method is overriden with a completely different behaviour). This is a violation of Liskov Substitution Principle.
  
- The second approach uses Strategy Pattern to get around this issue. It is still not a perfect solution, but it is SOLID. 
  As a general rule of thumb: Whenever you see a ton of if statements, it is very likely that you can use Strategy Pattern to clean it up.
  
Feel free to email any of us regarding any questions you might have at:

Andrei Apetrei
andrei.apetrei@centric.eu

Răzvan Rădeanu
razvan.radeanu@centric.eu

Radu Șolcă
radu.solca@centric.eu
  
