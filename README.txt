Thursday the twelfth.  One day before Friday the Thirteenth, of course.
It could have been worse.  Writing a Java version, for example!  But we
stuck to that clean and clear language chosen by millions for its ease
of use.  It had to be Javascript on the night.

And we nearly made it!

This is my attempt in C#, complete with GUI (wow) and Test Data (oooh).
I have to admit it took a lot longer than I expected to get everything
done.  And I've stopped before trying to optimise anything.

My aim here was to use LINQ and enumerables as much as possible, allowing
lazy execution.  Shuffling the deck forces enumeration of the dealt deck.
Checking how many cards were dealt (to catch the end of deck condition)
forces enumeration of the hand (which is a shame as most of the other code
tries to avoid this very thing!).
