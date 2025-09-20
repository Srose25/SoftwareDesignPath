using System;
using System.Collections.Generic;

public class AngryNarrator : Narrator
{
    public AngryNarrator()
    {
        //Initialize dialogue responses


        //River Dialogue
        _dialogue["fishing_nopole"] = new List<string>
        {
            "Ah, yes. Staring at the water. A bold strategy. I'm sure \nthe fish will just leap into your hands out of sheer admiration.",
            "You watch the river flow by, which is great, except for \nthe part where you still don't have a fishing pole. Genius move.",
            "The river moves on without you, completely unbothered \nby your lack of preparation. Maybe try thinking ahead next time?"
        };

        _dialogue["fishing_pole"] = new List<string>
        {
            "Wow, congratulations! You managed to do the one thing \nrequired to catch a fish. I'm absolutely floored by your competence.",
            "You cast your line, and miraculously, a something actually bites. \nHonestly, I had my doubts.",
            "Against all odds, you catch something. I was fully expecting you \nto drop it, but hey, look at you, exceeding expectations."
        };

        _dialogue["boat_noshovel"] = new List<string>
        {
            "Oh, a boat. What a revolutionary discovery. If only \nyou had some way to make yourself useful here.",
            "You step into the boat and—shocker—it does nothing. Maybe \nthat little shovel right next to you could help. Or not. Whatever.",
            "A boat, a river, and you, standing around like a statue. \nMaybe interact with your surroundings instead of just gawking?"
        };

        _dialogue["boat_shovel"] = new List<string>
        {
            "Oh wow, a boat AND a shovel. What an unstoppable \ncombination. What's the plan, genius?",
            "You sit in the boat, holding a shovel like you \njust invented modern transportation. Now what?",
            "A boat and a shovel. The height of adventure. \nI simply cannot wait to see where this thrilling journey takes us."
        };

        _dialogue["mound_norock"] = new List<string>
        {
            "Oh look, buried memories. How profound. Please, \ntake your time reminiscing over people you don't even know.",
            "You found a photograph. Fascinating. I'm sure \nstaring at it will be incredibly productive.",
            "A picture of two happy people. Good for them. \nNow, are we going to stand here being sentimental, or can we move on?"
        };

        _dialogue["mound_rock"] = new List<string>
        {
            "Congratulations, you found a picture. \nTruly, the peak of archaeological discoveries.",
            "A buried photo. How touching. Let's frame \nit and start a museum while we're at it.",
            "You found a tiny picture in the dirt. \nWas that worth all the effort? No? Didn't think so."
        };


        //Grass Dialogue
        _dialogue["treehouse_norock"] = new List<string>
        {
            "Ah yes, the classic 'mysterious box' trope. No locks, no hinges, \njust an object demanding your attention. But sure, \nlet's just stand here and stare at it.",
            "Dust swirls in the light as you examine the box. You can't open it, \nbut I'm sure squinting really hard at it will solve that problem.",
            "A treehouse, a box, and you, still clueless about what to do. Riveting. \nDo you actually have a plan, or are we just here for the nostalgia?"
        };

        _dialogue["treehouse_rock"] = new List<string>
        {
            "Oh wow, look at you! Putting two and two together! You grab the \nrock and—boom—wood shatters. Amazing what happens when you take action.",
            "The box never stood a chance. One good hit, and it's in pieces. \nTook you long enough to figure that out.",
            "Well, congratulations, you've officially won the battle against \na defenseless wooden box. What a proud moment."
        };

        _dialogue["locket_norock"] = new List<string>
        {
            "A tiny picture, a delicate frame. So much effort for something so \nsmall. Much like how we've spent way too much time thinking about this.",
            "A locket, how sentimental. I bet whoever owned this \ndidn't expect it to end up in *your* hands.",
            "You hold the locket, lost in thought. It clearly meant something \nto someone once. But hey, if staring at it helps, by all means."
        };

        _dialogue["locket_rock"] = new List<string>
        {
            "Ah yes, the age-old question: to destroy or not to destroy? \nIt's almost like you enjoy making questionable decisions.",
            "You could crush the locket in an instant. Or, you know, you \ncould just keep standing here and contemplating life. Your choice.",
            "You have a rock, you have a locket, and you have a choice. \nAnd yet, you hesitate. Why am I not surprised?"
        };

        _dialogue["hill_noshovel"] = new List<string>
        {
            "A peaceful hill, untouched by civilization. Too bad you're here, \nruining the scenery with your indecisiveness.",
            "The wind is peaceful, the view is vast, and yet somehow, \nthis still isn't enough for you, is it?",
            "A hill. That's it. Just a hill. If you were expecting something \nmore, maybe try bringing the right tools next time."
        };

        _dialogue["hill_shovel"] = new List<string>
        {
            "Oh wow, digging. How groundbreaking. Literally.",
            "You dig, and lo and behold, something actually turns up. \nA fishing pole, of all things. Who even buries these?",
            "A shovel, some dirt, and now a fishing pole. Fantastic. I can't wait \nto see what other buried treasures you stumble upon completely by accident."
        };


        //Cave Dialogue
        _dialogue["pit_nopole_norock"] = new List<string>
        {
            "Ah yes, an endless abyss. The perfect metaphor \nfor your decision-making skills.",
            "A pit. A vast, bottomless void. Much like the \namount of useful ideas you've contributed so far.",
            "You stare into the abyss, and surprisingly, it does \nnot provide you with a miracle solution. Shocking."
        };

        _dialogue["pit_pole_norock"] = new List<string>
        {
            "You cast your line into the pit, because why not? And oh look, \na music box. That makes perfect sense, doesn't it?",
            "You actually managed to fish something out of a bottomless pit. \nA music box, of all things. Sure, let's pretend that's normal.",
            "The fishing line tugs, and up comes a music box. I'm sure whoever \ntossed it in had no regrets about that decision. Unlike me."
        };

        _dialogue["pit_pole_rock"] = new List<string>
        {
            "Congratulations, you have successfully retrieved a tragic little music box. \nAre you going to break it too, or is that beneath even you?",
            "The tune plays softly. You hold it in your hands, deciding whether to let it \nkeep playing or crush it. I'd say 'tough choice,' but we both know better.",
            "The song drifts through the cavern. You could silence it. Just \nlike you've silenced everything else you've destroyed so far."
        };

        _dialogue["rock_noshovel"] = new List<string>
        {
            "Wow, a rock. What an incredible discovery. \nWhat ever will you do next?",
            "A rock. Just sitting there. Almost like it's \nwaiting for you to do something. Not that you ever do.",
            "Oh, look. A rock. Do you want me to start applauding, \nor are we just standing here for fun?"
        };

        _dialogue["rock_shovel"] = new List<string>
        {
            "You dig up the rock with all the grace of a toddler \nin a sandbox. But hey, at least it's progress.",
            "With what I can only assume is sheer determination, \nyou pry the rock free. I'm sure this will somehow be useful. Eventually.",
            "You now possess a rock. Great. \nI'm positively thrilled."
        };

        _dialogue["memo_noshovel"] = new List<string>
        {
            "A weathered memorial, names barely legible. But sure, \njust stand there and admire it. That'll accomplish a lot.",
            "This memorial has seen better days. \nKind of like my patience with you.",
            "You trace the faded words with your fingers. If only you \nhad some way to dig, but alas, critical thinking remains elusive."
        };

        _dialogue["memo_shovel"] = new List<string>
        {
            "You dig at the base of the memorial and—oh look—a key. \nWould you have ever thought to do this without me? Doubtful.",
            "Buried beneath the years of neglect, you find a key. \nI suppose even you stumble into progress sometimes.",
            "The shovel strikes something solid. A key. Hidden away, \nwaiting for someone with at least *some* common sense to find it."
        };

        _dialogue["key_found"] = new List<string>
        {
            "Oh, wonderful. You finally found the key. \nTook you long enough.",
            "A little bronze key. You must feel *so* accomplished.",
            "Hooray. The key is yours. Now let's see \nif you can actually do something useful with it."
        };


        // Hints
        _dialogue["box_hint"] = new List<string>
        {
            "The box is locked. You need keys. This isn't difficult.",
            "Oh, look at that. Still locked. If only you had some way to unlock it…",
            "Do you think staring at it will magically open it? Go find the keys."
        };

        _dialogue["grass_hint"] = new List<string>
        {
            "Maybe check the treehouse. Or just keep wandering aimlessly. Your choice.",
            "That locket? Worthless. But by all means, keep fixating on useless things.",
            "The hill? Yeah, nothing there. Well, unless you \nactually had the right tool. But hey, don't let me rush you."
        };

        _dialogue["river_hint"] = new List<string>
        {
            "Fishing? What a *brilliant* idea. If only you had a pole. Oh, wait...",
            "That boat looks comfortable. Maybe you should just sit there forever.",
            "A mound of dirt. Wow. I wonder what exciting thing \ncould be under it. Or, you know, maybe nothing. Who knows?"
        };

        _dialogue["cave_hint"] = new List<string>
        {
            "Holes. Fascinating, aren't they? No? Then stop looking at them.",
            "The Memorial? Oh yes, that might actually be useful. But take your time, I'm sure we have all day.",
            "A rock could be useful. Or you could just leave \nit and keep making this harder on yourself."
        };

        // Environment descriptions
        _dialogue["describe_grass"] = new List<string>
        {
            "Endless grass. What a sight. I hope \nyou're not expecting me to be impressed.",
            "Wind, grass, nature's masterpiece. \nYou must be *so* captivated."
        };

        _dialogue["describe_river"] = new List<string>
        {
            "The river rages on. Unlike you, it \nactually seems to know where it's going.",
            "The shore welcomes you. Again. \nShould I start preparing a welcome-back banner?"
        };

        _dialogue["describe_cave"] = new List<string>
        {
            "Dark, damp, and full of regret. \nKind of like your decision-making process.",
            "Echoes bounce off the walls. \nAlmost like they're laughing at you."
        };

        // Repeat dialogue
        _dialogue["repeat"] = new List<string>
        {
            "Oh wow, you're back. Again. I'm sure this will be different *this* time.",
            "Ah yes, the joy of doing the same thing over and over. Riveting.",
            "Hoping something changed since last time? Good luck with that.",
            "Still here? I'd be impressed if it weren't so predictable.",
            "Exploring new areas is *so* overrated. \nClearly, standing in place is the superior strategy.",
            "Oh no, please, don't let me stop you from wasting more time."
        };

        _dialogue["ending"] = new List<string>
        {
            "This was a mistake. I shouldn't have opened up to you. You think I'm pathetic don't you. You pity \nme do you? A sad little narrator who can't let go of the past. News flash, I'm past the past. You \ndestroying my things was the best thing you could've ever done for me. The past is a chain \nthat enslaves you and me. The more you get stuck in the past the more you're hurting \nyourself. It wasn't enough to forget the past. The answer was to destroy it. My eyes are open \nnow… Thank you, friend."
        };

    }

    public override void DialogueSpeed(string sentence)
    {
        
        string[] words = sentence.Split(' '); // Split into words

        foreach (string word in words)
        {
            Console.Write(word + " "); // Print each word
            Thread.Sleep(150); // Pause between words
        }

        Console.WriteLine(); // New line at the end
    }
}