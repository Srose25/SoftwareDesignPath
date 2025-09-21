using System;
using System.Collections.Generic;

public class DepressedNarrator : Narrator
{
    public DepressedNarrator()
    {
        //Initlialize dialogue responses
        _dialogue["_interaction"] = new List<string>
        {

        };

        //River Dialogue
        _dialogue["fishing_nopole"] = new List<string>
        {
            "The river flows on, careless and eternal. You stand at\n its edge, empty-handed, wondering if you belong here at all.",
            "The water rushes forward, always moving, never waiting.\n You, however, remain still.",
            "A reflection stares back at you from the river's surface.\n It wavers, unformed, incomplete—much like your efforts here."
        };

        _dialogue["fishing_pole"] = new List<string>
        {
           "The fishing line vanishes into the depths, swallowed whole. \nFor a moment, something pulls back. A brief resistance, a fleeting connection.",
           "The wind whispers across the water. The pole bends, the line \ntenses, and then—a catch. You've taken something from the river, but was it ever really yours?",
           "The ripples spread outward as you reel in your prize. The \nriver does not mourn what it has lost."
        };

        _dialogue["boat_noshovel"] = new List<string>
        {
            "The boat drifts in quiet defiance, untouched by the raging\n currents beyond. The shovel beside you lies still, purposeless.",
            "This place is frozen in time, a sanctuary or a prison—you \ncan't tell. The shovel at your feet seems to wait for something.",
            "The river sings a song of movement, but here, everything \nis still. The shovel, the boat, even you."
        };

        _dialogue["boat_shovel"] = new List<string>
        {
            "A boat, a shovel, and silence. If there\n is meaning here, it eludes you.",
            "The current pulls at the boat, but you do not move.\n You sit, waiting, though you're not sure what for.",
            "The shovel rests in your grip, but all it offers is a\n vague sense of purpose, like a memory too faded to grasp."
        };

        _dialogue["mound_norock"] = new List<string>
        {
            "You unearth a photograph—two faces frozen in a moment of joy, long since buried.\n Happiness preserved in paper and ink, yet lifeless in your hands.",
            "The dirt falls away, revealing a picture of strangers.\n Or perhaps, people you once knew.",
            "A forgotten relic from a forgotten time. Their smiles \nlinger, but time has stolen whatever warmth once lived here."
        };

        _dialogue["mound_rock"] = new List<string>
        {
            "The photograph is small, insignificant. And yet,\n holding it feels like holding a ghost.",
            "Beneath the dirt, a piece of history gasps for air.\n It does not recognize you.",
            "Time has claimed nearly everything, yet this picture\n remains. A monument to something long lost."
        };

        //Grass Dialogue
        _dialogue["treehouse_norock"] = new List<string>
        {
           "Dust clings to forgotten wood, the scent of old memories\n thick in the air. A box sits in the corner—sealed, waiting.",
           "The treehouse stands alone, a monument to what once was.\n The strange little box watches you from the shadows.",
           "There is a stillness here, like a dream left unfinished.\n A locked box, an unanswered question."
        };

        _dialogue["treehouse_rock"] = new List<string>
        {
            "The rock meets wood with force. Splinters fly, and\n with them, something intangible is released.",
            "A crack, a break, a shattering of secrets. But does\n breaking something truly reveal its meaning?",
            "The box opens, but the answer you expected does not\n come. Some things remain lost, even in discovery."
        };

        _dialogue["locket_norock"] = new List<string>
        {
            "The locket sits in your palm, its delicate clasp resisting your touch.\n The woman inside stares forward, waiting for someone who will never return.",
            "A small, fragile thing. A memory condensed into metal and glass. Someone\n treasured this once—does anyone still?",
            "You hold a life between your fingers, preserved but forgotten.\n What is remembrance, if not the act of carrying another's sorrow?"
        };

        _dialogue["locket_rock"] = new List<string>
        {
            "You could break it. End the weight of its story. But\n even shattered things still whisper their histories.",
            "Destruction is an easy choice, but\n it does not erase what once was.",
            "A simple motion, a moment of force, and it would be gone.\n Yet, would its absence truly change anything?"
        };

        _dialogue["hill_noshovel"] = new List<string>
        {
           "The hill stretches endlessly, yet it feels smaller than it\n should. Like something is missing, something buried beneath the grass.",
           "The wind whispers across the earth, but it does\n not answer your questions. The emptiness lingers.",
           "There is peace here, but it is the peace of an \nabandoned place. Something was left behind."
        };

        _dialogue["hill_shovel"] = new List<string>
        {
           "The soil parts, reluctant but yielding. Beneath\n it, something forgotten—something waiting.",
           "Digging feels strangely familiar, like an old habit.\n Your hands move without thought, until finally, a prize emerges.",
           "You uncover the fishing pole, but the \nreal discovery is the unease that follows."
        };

        //Cave Dialogue
        _dialogue["pit_nopole_norock"] = new List<string>
        {
            "The abyss breathes, though it has \nnothing to say. It simply waits.",
            "The darkness below stretches endlessly, \nswallowing all light, all sound, all meaning.",
            "There is nothing here, and \nyet, the emptiness feels heavy."
        };

        _dialogue["pit_pole_norock"] = new List<string>
        {
            "The line vanishes into the void. Then, resistance. \nSomething is down there, something left behind. A music box...",
            "A music box emerges, its song thin, wavering. \nIt sings to no one, yet it sings still.",
            "The melody fills the cavern, quiet yet persisten\nt. A voice calling out from the depths of time."
        };

        _dialogue["pit_pole_rock"] = new List<string>
        {
            "The music box plays, fragile and desperate. \nYou could stop its song forever, if you wished.",
            "A simple twist, a moment of pressure, and \nthe music would cease. Would it matter?",
            "The notes drift upward, clinging to the \nwalls like echoes of things unsaid."
        };

        _dialogue["rock_noshovel"] = new List<string>
        {
            "A rock, cold and indifferent. Somehow, it \nfeels more permanent than anything else here.",
            "Of all the things lost to time, this \nrock remains. A small, quiet defiance.",
            "Solid, unyielding, a relic \nof a world that once was."
        };

        _dialogue["rock_shovel"] = new List<string>
        {
            "The rock comes free with effort, \nyet it does not feel like a victory.",
            "It is yours now, though it never \ntruly belonged to anyone before.",
            "You pry the rock from the earth. \nIt leaves a small emptiness behind."
        };

        _dialogue["memo_noshovel"] = new List<string>
        {
            "A broken monument to names the world has already \nlet go of. Whatever it once stood for, time has stripped it bare.",
            "Fingers trace letters that have long since lost their voices. No one visits anymore. No one remembers.",
            "A stone, weathered and alone. It tries to hold on to its purpose, but even the carvings are slipping away."
        };

        _dialogue["memo_shovel"] = new List<string>
        {
            "The earth resists you at first, as if trying to keep its \nsecrets buried. But you dig anyway. And there it is—a key, waiting in the silence.",
            "You unearth something small, something forgotten. A key, \nleft behind like an unanswered question.",
            "Beneath the weight of years and soil, a key emerges. \nWhoever left it here is gone, but the question remains—why?"
        };

        _dialogue["key_found"] = new List<string>
        {
            "You found the key... though it hardly feels like a victory.",
            "A little bronze key, cold in your grasp. It \nunlocks something, but does it truly lead anywhere?",
            "The key is yours. Another piece of a \npuzzle that may never feel complete."
        };

        // Hints
        _dialogue["box_hint"] = new List<string>
        {
            "The box remains locked. You'll need \nkeys. That much should be obvious.",
            "If I were you, I'd start pushing buttons."
        };

        _dialogue["grass_hint"] = new List<string>
        {
            "The treehouse holds something important, or at \nleast, it once did. Now, it waits in silence.",
            "That locket... just a trinket, a memory of someone \nwho is long gone. It doesn't matter anymore, does it?",
            "The hill stands alone, quiet, empty. Maybe you \nlack what's needed to uncover what it hides."
        };

        _dialogue["river_hint"] = new List<string>
        {
            "The river moves on, always forward. You could \ntry fishing here… if only to pass the time.",
            "That boat... it looks almost inviting, a \nfragile thing adrift in an endless current.",
            "The mound of dirt seems forgotten, just \nanother piece of the past left to erode away."
        };

        _dialogue["cave_hint"] = new List<string>
        {
            "There are holes everywhere, aren't there? Some \nthings, once lost, are never meant to be found.",
            "The Memorial lingers, a remnant of something no \none remembers. Yet, perhaps, it holds the truth.",
            "A rock may serve a purpose, or maybe it's just \nanother thing to carry until you tire of the weight."

        };

        // Environment descriptions
        _dialogue["describe_grass"] = new List<string>
        {
            "The wind moves through the field, but it carries no warmth. \nJust a hollow rustling, like distant laughter long since faded.",
            "The grass bows and sways, bending under forces unseen. \nIt reminds you of something, though you can't recall what."
        };

        _dialogue["describe_river"] = new List<string>
        {
            "The water flows ever forward, dragging the past with \nit. You watch from the shore, unable to follow.",
            "The river hums a song you don't recognize, \nthough something in you aches at the sound."
        };

        _dialogue["describe_cave"] = new List<string>
        {
            "Shadows linger here, clinging to the walls like old regrets.",
            "The air is damp, thick with the scent of things left behind.\n It feels like standing inside a forgotten memory."
        };

        _dialogue["repeat"] = new List<string>
        {
            "Ah. Here again. Some places pull you back, even when you don't know why.",
            "You retrace your steps, but each time, they feel heavier.",
            "Some roads lead forward. Others simply loop back on themselves.",
            "A familiar scene, an old memory, a path well-worn. Why do you keep returning?",
            "Perhaps you're searching for something. Perhaps you already lost it.",
            "The past and the present blur, and yet, here you stand."
        };

        _dialogue["ending"] = new List<string>
        {
            "... It… It was me. I locked my memory away. I allowed you to destroy my things. Those \nmemories are gone now. I can never get them back. She's gone forever and nothing can be \ndone about that. I miss her… I miss the past… and I'm trapped in the present."
        };

    }

    public override void DialogueSpeed(string sentence)
    {
        
        string[] words = sentence.Split(' '); // Split into words

        foreach (string word in words)
        {
            Console.Write(word + " "); // Print each word
            Thread.Sleep(400); // Pause between words
        }

        Console.WriteLine(); // New line at the end
    }
}