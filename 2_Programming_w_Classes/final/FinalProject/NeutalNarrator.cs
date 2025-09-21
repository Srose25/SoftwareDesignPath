using System;
using System.Collections.Generic;

public class NeutralNarrator : Narrator
{
    public NeutralNarrator()
    {
        // Initialize dialogue responses

        //River Dialogue
        _dialogue["fishing_nopole"] = new List<string>
        {
            "The water rushes by as you ponder, how will I catch a fish?",
            "You watch the water flow, but without a fishing pole, you're left with only your thoughts.",
            "The river moves steadily, indifferent to your dilemma. Perhaps you need the right tool for the job."
        };

        _dialogue["fishing_pole"] = new List<string>
        {
            "The wind in your hair, the mist across your body, and the smile on your face.\n You plunge the fishing rod down into the depths and wait patiently.\n Suddenly a tug at the twig and out of the water it launches!",
            "With patience, you cast your line into the current. A moment\n passes, then—success! A key leaps from the water, caught in your grasp.",
            "The river is alive with motion, and for a moment, so are you. A tug on the line, a swift pull, and a fish breaks the surface."
        };

        _dialogue["boat_noshovel"] = new List<string>
        {
            "The boat is tranquil despite the rushing water off in the distance.\n You notice next to you a little shovel. This may be useful.",
            "You step into the boat, feeling it rock gently beneath you.\n A small shovel lies nearby, seemingly waiting for a purpose.",
            "The quiet of the river surrounds you. A lone shovel rests\n beside you, its presence strangely inviting."
        };

        _dialogue["boat_shovel"] = new List<string>
        {
            "Just you, a shovel, and a boat. What could be better than this?",
            "You sit in the boat, shovel in hand.\n It's a peaceful moment, though you can't shake the\n feeling that there's something more to do.",
            "A boat and a shovel—unlikely companions,\n yet here they are, waiting with you on the water."
        };

        _dialogue["mound_norock"] = new List<string>
        {
            "You unearth a small frame with a picture that\n seems like it was taken a long time ago. It's\n of a man and a woman. They seem happy together.",
            "Beneath the dirt, you find a framed photograph. The image\n is faded, but the expressions remain—content, hopeful.",
            "The ground gives way to a small picture frame. The faces within\n belong to a time long past, yet they still linger here."
        };

        _dialogue["mound_rock"] = new List<string>
        {
            "You unearth a small picture. The item itself\n is worthless, but the memories are priceless.",
            "The dirt shifts away, revealing a tiny photograph. The\n past lingers in its edges, even if the meaning is lost.",
            "A picture buried beneath the earth, waiting to be found.\n Its story is unknown, but its presence is undeniable."
        };

        //Grass Dialogue
        _dialogue["treehouse_norock"] = new List<string>
        {
            "The inside of the treehouse reminds you of\n a younger time. In the corner is a little box with\n no openings or locks. It does, however, look breakable.",
            "Dust lingers in the air, caught in the fading light. \nThe strange box sits in the corner, silent, waiting.",
            "The treehouse stands frozen in time, untouched yet worn.\n The small, unopenable box remains where it always has."
        };

        _dialogue["treehouse_rock"] = new List<string>
        {
            "You investigate the treehouse and find little interesting about it.\n You find the box that seemed unopenable not too long ago. You take\n your rock and strike the box with everything you have!",
            "With the rock in hand, the box no longer seems so mysterious.\n A single strike—splintering wood, a quiet resolve.",
            "The box meets the rock, and for a moment, nothing happens.\n Then—crack. The mystery begins to unfold."
        };

        _dialogue["locket_norock"] = new List<string>
        {
            "There is something unnerving about this little trinket.\n On the one hand, it's just a simple picture of a woman, nothing of note.\n However, someone went through the trouble of printing this so small,\n and then to put that picture in a frame that is now wearable.\n She must have meant a lot to him.",
            "A small locket rests in your hand, its clasp worn from use.\n Inside, the image of a woman, carefully preserved.",
            "You hold the locket up to the light. A woman's face looks\n back at you, frozen in time, her significance a quiet mystery."
        };

        _dialogue["locket_rock"] = new List<string>
        {
            "The locket has puzzled you long enough. You\n have the power to destroy it if you like.",
            "The weight of the locket is small, yet something about it feels heavy.\n You could rid yourself of that weight with a single motion.",
            "You run your fingers over the locket's surface. To\n keep or to break—such a simple decision, yet it lingers."
        };

        _dialogue["hill_noshovel"] = new List<string>
        {
            "A tranquil hill far away from civilization. On paper,\n it sounds like a dream, but now that you're here,\n you can't help but feel like you're missing something.",
            "The breeze carries a quiet stillness over the hilltop.\n There's peace here, but also an absence.",
            "The view stretches far and wide, yet something feels\n incomplete. Perhaps there's more beneath the surface."
        };

        _dialogue["hill_shovel"] = new List<string>
        {
            "What's better than a hill? A hole, of course.\n You begin digging and find a real treasure—a fishing pole!\n Who went through all the trouble of putting this down here?",
            "The ground gives way beneath your shovel.\n After a few moments, your effort is rewarded—someone\n buried a fishing pole here.",
            "You dig, expecting nothing, yet uncover something—a fishing pole.\n Forgotten or hidden? The answer remains unknown."
        };

        //Cave Dialogue
        _dialogue["pit_nopole_norock"] = new List<string>
        {
            "The cavern seems to slowly drip down into the endless abyss.",
            "A quiet emptiness stretches downward, the depths holding their secrets close.",
            "The abyss stares back at you, vast and silent, offering no answers."
        };

        _dialogue["pit_pole_norock"] = new List<string>
        {
            "You toss your fishing pole into the bottomless pit and manage to find a music\n box. It sings its precious lullaby. Who would throw something so precious away?",
            "The fishing line catches onto something. As you reel it in,\n a soft melody fills the air—a music box, lost but not forgotten.",
            "Your pole finds purchase in the void. Slowly, you pull up\n an object—a music box, its song delicate yet enduring."
        };

        _dialogue["pit_pole_rock"] = new List<string>
        {
            "You toss your fishing pole into the bottomless pit and manage to find a music box.\n It sings its precious lullaby. It seems unwanted.\n You have the power to take it out of its misery.",
            "The melody drifts through the cavern, soft yet heavy. You\n hold the music box in your hands. A single action could silence it forever.",
            "The song lingers, its notes echoing off the stone. The\n music box rests in your grasp, waiting for a choice."
        };

        _dialogue["rock_noshovel"] = new List<string>
        {
            "Man, having a rock like this would be so cool.",
            "A solid, sturdy rock sits before you. Quite the find.",
            "It's just a rock, yet something about it feels... right."
        };

        _dialogue["rock_shovel"] = new List<string>
        {
            "You shovel the rock with all your might.\n A mighty rock for a mighty lad.",
            "With effort, you pry the rock loose.\n It's heavier than expected, but yours now.",
            "The shovel gives you just enough leverage to\n claim your prize—a simple rock, yet undeniably yours."
        };

        _dialogue["memo_noshovel"] = new List<string>
        {
            "A weathered stone stands before you, its surface \netched with names long forgotten. Time has not been kind to it.",
            "The memorial is old, its carvings worn by the years.\n Someone must have cared once, but now it stands alone.",
            "You run your fingers across the rough surface. The \nwords are faded, but their weight still lingers."
        };

        _dialogue["memo_shovel"] = new List<string>
        {
            "You dig at the base of the memorial, unearthing \nsomething hidden beneath the years. A key, buried in silence.",
            "Beneath the dirt, something glints in the dim light. A\n small key, as if left behind for someone to find.",
            "The shovel scrapes against something solid. As you lift it\n from the earth, you realize—this was meant to be uncovered."
        };


        _dialogue["key_found"] = new List<string>
        {
            "Well done, you found the key.",
            "The little bronze key is now within your grasp.",
            "Good job, the key is yours."
        };

        // Hints
        _dialogue["box_hint"] = new List<string>
        {
            "The box remains locked. You'll need keys. That much should be obvious.",
            "If I were you, I'd start pushing buttons."
        };

        _dialogue["grass_hint"] = new List<string>
        {
            "My guess is something important is over in that tree house.",
            "That locket doesn't seem important.",
            "There doesn't seem to be anything over at the hill but you may not have the right tool yet."
        };

        _dialogue["river_hint"] = new List<string>
        {
            "It would be nice to go fishing here. You should look into that.",
            "That boat is really cute, it may be nice to sit in it.",
            "That mound of dirt seems pretty useless."
        };

        _dialogue["cave_hint"] = new List<string>
        {
            "Holes don't seem to be worth our time.",
            "The Memorial probably contains the biggest secret.",
            "A rock may be useful in some cases."
        };

        // Environment descriptions
        _dialogue["describe_grass"] = new List<string>
        {
            "The grass stretches endlessly. If you stare too\n long, you might get lost in its beauty.",
            "Green, swaying, utterly remarkable. The wind feels\n like the nearly forgotten touch of a loved one."
        };

        _dialogue["describe_river"] = new List<string>
        {
            "The River flows like a raging storm off in the distance,\n but at the shore it still seems so peaceful.",
            "The shore of the river greets you like an old friend.\n The beautiful sound of the water rushing by fills your soul."
        };

        _dialogue["describe_cave"] = new List<string>
        {
            "Dark, damp, and full of regret. This Cave seems to shedding a tear for something...",
            "Echoes bounce off the cave walls. It's like they're speaking to me."
        };

        _dialogue["repeat"] = new List<string>
        {
            "Ah, back again? Guess you just can't get enough of this place.",
            "Familiar sights, familiar actions. A classic choice.",
            "Déjà vu? No, just a well-trodden path.",
            "Revisiting past decisions... or just stalling for time?",
            "You know, there are other things to explore, but hey, do what makes you happy.",
            "Some say repetition is the key to mastery. \nOthers say it's just habit. Either way, here we are."
        };

        _dialogue["begin"] = new List<string>
        {
            "Memories. The connective tissue between our conscious minds and reality. Without it \nwhat are we? That is the question I've been asking my self for a long time, traveler. I've lost \nmy memories. They've been locked away in this box, and only you can find the keys that \nunlock it. Please help me traveler."
        };

        _dialogue["ending"] = new List<string>
        {
        "Ah… I see. I see now why I locked this box… As much pain as these memories brought me, \nI'm glad you helped me, traveler. I see now that locking this pain away was not helpful to me \nat all. Forgetting the good memories is worse than having to live with the pain of these bad \nmemories. Embracing the pain is the only way we can live. Thank you, friend. Thank you…"
        };
    }

    public override void DialogueSpeed(string sentence)
    {
        
        string[] words = sentence.Split(' '); // Split into words

        foreach (string word in words)
        {
            Console.Write(word + " "); // Print each word
            Thread.Sleep(250); // Pause between words
        }

        Console.WriteLine(); // New line at the end
    }
}
