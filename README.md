# Decorator Pattern

### About
In these repositories, some design patterns are implemented to a mini game system for self education. They may not be suited to use in an actual game (directly anyway). However, it is good to have some examples underhand to take reference. And even if anyone wants to use them, you are welcome.

### Definition
Decorator pattern, attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extended functionality.

### Description
After the battle with goblin, our character wants to power up his weapon with runes. Runes may increase our weapons' damage, critical chance, adds fire damage etc... So they will add some additional effects to our equipments, change their values or calculations. So what can we do here? Should we keep the runes in an array and check if there is any rune, and if there is then check which one it is, if it just increase some values or applies some additional effect... Even while writing, I got confused and couldn't follow my own sentence. Hmmm, I think it is not a good option.

So what if we could achieve this functionality even without changing our base class or without adding infinite if checks? Decorator pattern may come in handy here. We just need to add an additional decorator interface that subclasses the weapon interface and our runes will be the children of that decorator interface. So, runes will have every property of weapons and may change its values, calculations, add new functionalities etc... And the best part is, the one know that what is going on will be rune classes themselves. Our weapon classes won't know anything about runes. If we want to add new runes to our game, we just need to create a class that extends decorator interface and we are ready to go. We won't be needed to make any additional change in our weapon interface.
