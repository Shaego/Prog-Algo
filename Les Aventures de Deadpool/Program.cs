using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix = 0;
            int pouce = 0;
            int esquive = 0;

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            //DEBUT

            Console.WriteLine("Bienvenue, jeune (ou vieux) joueur, dans ce conte farfelu qu'est :");
            Console.WriteLine("");
            Console.WriteLine("LES AVENTURES DE DEADPOOL");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Le but est simple, tu devras suivre l'histoire et faire des choix,");
            Console.WriteLine("à l'aide des touches 1, 2 ou parfois 3.");
            Console.WriteLine("");
            Console.WriteLine("Pour garantir une bonne vision de l'histoire, merci de mettre la fenêtre en grand écran.");
            Console.WriteLine("J'espère que cette histoire te plaira.");
            Console.WriteLine("");
            Console.WriteLine("Il était une fois... TOI");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Bonjour, Deadpool, tu te réveilles dans ton appartement, tu as fait un drôle de rêve");
            Console.WriteLine("Mais cela n'a aucune importance, que souhaites tu faire aujourd'hui ?");
            Console.WriteLine("Fais un choix, tu restes à la maison (1) Ou tu sors ?(2)");
            choix = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (choix == 1) //Rester
            {
                Console.WriteLine("Oui tu as raison, restons un peu à la maison");
                Console.WriteLine("Mais tu n'as pas grand chose à faire, que veux-tu faire ?");
                Console.WriteLine("Tu veux te confier à ta licorne en peluche (1) ? Ou tu préfères t'ennuyer (2) ?");
                choix = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (choix == 1) //Secret
                {
                    Console.WriteLine("Oh oh petit cachotier !");
                    Console.WriteLine("Tu as raconté à ta Licorne que tu pensais vraiment que Trump président");
                    Console.WriteLine("C'était un prank qui avait mal tourné.");
                    Console.WriteLine("Enfin bon... Il est temps de sortir !");
                }
                else if (choix == 2) //L'ennui
                {
                    Console.Clear();
                    Console.WriteLine("Tu as préfèré t'ennuyer ? Vraiment ?! Mais..VRAIMENT ?!!");
                    Console.WriteLine("Bon, tu passes environ 5h à faire l'hélico avec ta Banane (Une vraie banane, t'as vraiment l'esprit fucké!)");
                    Console.WriteLine("Enfin bref, il est temps de sortir");
                }

            }

            afficherScenarioSortie(); //Sortir
            choix = Convert.ToInt32(Console.ReadLine());

            if (choix == 1) //Marcher
            {
                Console.Clear();
                Console.WriteLine("Rien de mieux qu'une petite promenade n'est ce pas ?");
                Console.WriteLine("Tu marches pendant une dizaine de minutes, quand soudain tu aperçois une ombre derrière toi, tu te retournes...");
                Console.WriteLine("Une immense porte s'est dressée devant toi, faite de pierre et de squelettes humains");
                afficherScenarioPortail();
                choix = Convert.ToInt32(Console.ReadLine());


            }
            else if (choix == 2) //Taxi
            {
                Console.Clear();
                Console.WriteLine("Tu appelles un taxi ? C'est pour les obèses qui ont la flemme de marcher ça !");
                Console.WriteLine("");
                Console.WriteLine("Ton fidèle Doppinder viens te chercher et t'emmènes en virée");
                Console.WriteLine("Il te raconte comment il a encore séquestré l'amour de sa vie");
                Console.WriteLine("Pendant qu'il te parle, tu sens le sol trembler et regarde devant le taxi");
                Console.WriteLine("");
                Console.WriteLine("Une immense porte faite de pierre et de squelettes humains s'est dressée devant l'auto ");
                Console.WriteLine("Tu dois vite voir ce que c'est, décides tu de payer Doppinder (1) ou de le payer en check comme d'habitude (2) ?");
                choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1) //Payer Taxi
                {
                    Console.WriteLine("20$, sérieusement ? Après tout, t'es tueur à gâge tu t'en fiches, t'es riche");
                    Console.WriteLine("Tu sors du taxi");
                }
                else if (choix == 2) //Check Taxi
                {
                    Console.WriteLine("Tu fais un high five à Doppinder qui te souris tristement...");
                    Console.WriteLine("Tu sors de taxi");
                }
                afficherScenarioPortail();
                choix = Convert.ToInt32(Console.ReadLine());

            }



            if (choix == 1) //Portail Vert
            {
                Console.Clear();
                Console.WriteLine("Tu entres dans le portail vert, et une pression immense te frappe.");
                Console.WriteLine("Au fur et à mesure que tu avances, tu commences à distinguer une lumière.");
                Console.WriteLine("Tu t'en approches et au moment où tu la touches, tout autour de toi disparait.");
                Console.WriteLine("Tu flottes un instant dans le vide, avant que tout s'accélère et que tu tombe au sol.");
                Console.WriteLine("");
                Console.WriteLine("Tu te relèves, le sol est légerement mou. Tu regardes autour de toi, cela ressemble à...");
                Console.WriteLine("<Oui ben c'est une forêt merci Sherlock ! J'ai déjà vu des arbres abrutis !> dit Deadpool");
                Console.WriteLine("");
                Console.WriteLine("Alors que tu observes les alentours, tu vois l'entrée d'un village troll,");
                Console.WriteLine("Mais alors même que tu t'en approches, tu vois une sorcière fuir dans le sens opposé!");
                Console.WriteLine("Te voila dans un dilemne, que faire ! Allez dans le vilage troll (1), ou suivre la sorcière (2) ?");
                choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1) //Village Troll
                {
                    Console.Clear();
                    Console.WriteLine("Tu décides de rentrer dans le village Troll pour rencontrer les habitants");
                    Console.WriteLine("Tu te rends compte que cela fait vraiment longtemps que tu n'as tué personne");
                    Console.WriteLine("");
                    Console.WriteLine("Pour le bien de l'histoire, les trolls parlent français...");
                    Console.WriteLine("<Ah ouais tu t'es vraiment pas foulé là> dit Deadpool");
                    Console.WriteLine("");
                    Console.WriteLine("Deux choix s'offrent alors à toi,");
                    Console.WriteLine("Sois tu te sens gentil, et demande à voir le chef (pour le tuer) (1),");
                    Console.WriteLine("Sois tu te sens sanguinaire et pars pour massacrer le village entier (2)");
                    Console.WriteLine("Je te rassure, ni femme, ni enfant");
                    choix = Convert.ToInt32(Console.ReadLine());

                    if (choix == 1) //1v1 Chef
                    {
                        Console.Clear();
                        Console.WriteLine("Après avoir demandé à voir le chef, tu le vois qui approche.");
                        Console.WriteLine("Il a l'air en colère, en même temps, tu vas le tuer");
                        Console.WriteLine("Que le fun commence ! Choisis ton arme, il s'apprète à te charger, vite !");
                        Console.WriteLine("");
                        Console.WriteLine("Tes fidèles katanas Bea & Arthur (1), tu te sens fougeux, à mains nues (2)");
                        Console.WriteLine("Ou un lance roquette (on sait tous où tu le cachais)(3)");
                        choix = Convert.ToInt32(Console.ReadLine());

                        if (choix == 1) // Katanas
                        {
                            Console.Clear();
                            Console.WriteLine("Tu dégaines tes katanas et fonces sur le chef,");
                            Console.WriteLine("Alors qu'il frappe avec son bras, tu esquives aisément et passe sous ses jambes");
                            Console.WriteLine("(En passant sous ses jambes tu aperçois qu'il ne porte pas de culottes, beurk)");
                            Console.WriteLine("Tu finis de glisser, te relèves vite et avant même qu'il ait le temps de se retourner,");
                            Console.WriteLine("Tu lui saute sur les épaules et fait du rodéo avant de croiser tes lames devant sa gorge.");
                            Console.WriteLine("En prenant appui sur ses épaules, tu sautes en arrière et le décapite!");
                            Console.WriteLine("");
                            Console.WriteLine("MON-MON-MON-MONSTER KILL");
                        }
                        else if (choix == 2) // Mains nues
                        {
                            Console.Clear();
                            Console.WriteLine("Alors que le chef s'apprête à te charger, tu te retournes et baisse ton pantalon!");
                            Console.WriteLine("Le chef, encore plus en colère te charge à une vitesse effrayante.");
                            Console.WriteLine("Au moment où il allait te frapper, tu te décales légerement sur le côté...");
                            Console.WriteLine("Le chef ne pouvant pas s'arrêter s'empale sur le pieux qui était derrière toi et");
                            Console.WriteLine("");
                            Console.WriteLine("Meurt...(Évidemment)");
                        }
                        else if (choix == 3) //Rocket
                        {
                            Console.Clear();
                            Console.WriteLine("N'ayant pas que ça à faire, tu sors ton lance roquette et tire sur le chef.");
                            Console.WriteLine("Bien évidemment, le chef meurt, RIP looser !");
                        }
                        else { }

                        Console.Clear();
                        Console.WriteLine("Bon, voila une bonne journée de faite, rien de mieux que ce genre de combat pour te rendre heureux !");
                        Console.WriteLine("Avant de partir, tu sors du village et vois la sorcière de tout à l'heure. En te voyant, elle fuit et tu la suis.");

                    }
                    else if (choix == 2) //Massacre
                    {

                        Console.Clear();
                        Console.WriteLine("<Aujourdhui est un beau jour pour mourrir> Dit Deadpool");
                        Console.WriteLine("<C'est mon anniversaire ! Et vous êtes mes cadeaux !> Dit-il en dégainant ses katanas");
                        Console.WriteLine("Tu cours dans le village en brandissant tes lames dans tous les sens, des effusions de sang de toutes parts");
                        Console.WriteLine("Les villageois tombent un à un et meurent à une vitesse affolante");
                        Console.WriteLine("Tu te rapproches de la vitesse d'extinction des dinosaures");
                        Console.WriteLine("Après avoir fini ton massacre, tu relèves la tête. Les cris ont réveillés le chef");
                        Console.WriteLine("Il a l'air en colère, en même temps, tu vas le tuer");
                        Console.WriteLine("Que le fun commence ! Choisis ton arme, il s'apprète à te charger, vite !");
                        Console.WriteLine("");
                        Console.WriteLine("Tes fidèles katanas Bea & Arthur (1), tu te sens fougeux, à mains nues (2)");
                        Console.WriteLine("Ou un lance roquette (on sait tous où tu le cachais)(3)");
                        choix = Convert.ToInt32(Console.ReadLine());

                        if (choix == 1) // Katanas
                        {
                            Console.Clear();
                            Console.WriteLine("Tu dégaines tes katanas et fonce sur le chef,");
                            Console.WriteLine("Alors qu'il frappe avec sa massue, tu esquives aisément et passe sous ses jambes");
                            Console.WriteLine("(En passant sous ses jambes tu aperçois qu'il ne porte pas de culottes, beurk)");
                            Console.WriteLine("Tu finis de glisser, te relèves vite et avant même qu'il ait le temps de se retourner,");
                            Console.WriteLine("Tu lui saute sur les épaules et fait du rodéo avant de croiser tes lames devant sa gorge.");
                            Console.WriteLine("En prenant appui sur ses épaules, tu sautes en arrière et le décapite!");
                            Console.WriteLine("");
                            Console.WriteLine("MON-MON-MON-MONSTER KILL");
                        }
                        else if (choix == 2) // Mains nues
                        {
                            Console.Clear();
                            Console.WriteLine("Alors que le chef s'apprête à te charger, tu te retournes et baisse ton pantalon!");
                            Console.WriteLine("Le chef encore plus en colère te charge à une vitesse effrayante.");
                            Console.WriteLine("Au moment où il allait te frapper, tu te décales légerement sur le côté...");
                            Console.WriteLine("Le chef ne pouvant pas s'arrêter s'empale sur le pieux qui était derrière toi et");
                            Console.WriteLine("");
                            Console.WriteLine("Meurt...(Évidemment)");
                        }
                        else if (choix == 3) //Rocket
                        {
                            Console.Clear();
                            Console.WriteLine("N'ayant pas que ça à faire, tu sors ton lance roquette et tire sur le chef.");
                            Console.WriteLine("Bien évidemment, le chef meurt, RIP looser !");
                        }


                        Console.Clear();
                        Console.WriteLine("Bon, voila une bonne journée de faite, rien de mieux que ce genre de combat pour te rendre heureux !");
                        Console.WriteLine("Avant de partir, tu sors du village et vois la sorcière de tout à l'heure. En te voyant, elle fuit et tu la suis.");

                    }
                }

                afficherScenarioSorcière();
                choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1) //Kill Witch
                {
                    Console.Clear();
                    Console.WriteLine("Tu sors ton gun et lui explose la cervelle ! C'est gore, mais c'est beau");
                    Console.WriteLine("Alors que son sang forme une mare autour de son corps, la Mort apparait.");
                    Console.WriteLine("");
                    Console.WriteLine("<Tu es sérieux ?! Tu l'as tuée ? C'était une princesse !> s'écrit-elle");
                    Console.WriteLine("La Mort te proposes alors de la réscuciter. Que veux-tu faire ?");
                    Console.WriteLine("Tu préfères rentrer et oublier tout ça (1) ou la réscuciter (2) ?");
                    choix = Convert.ToInt32(Console.ReadLine());

                    if (choix == 1) //Rentre Fin1
                    {
                        Console.WriteLine("Tu rentres à la maison, du sang sur les mains, et avec une légère envie de Tacos.");
                    }
                    else if (choix == 2) //Rez Witch
                    {
                        Console.Clear();
                        Console.WriteLine("Bien, la sorcière s'enveloppe alors d'un voile magique et fini par se réveiller");
                        Console.WriteLine("Tu décides alors de l'embrasser (c'est moi qui raconte l'histoire ok ?)");
                        Console.WriteLine("Tu te penches vers elle et l'embrasse gouluement, de la salive coule.");
                        Console.WriteLine("");
                        Console.WriteLine("C'est alors qu'elle se transforme en une magnifique princesse, personne ne s'y attendait");
                        Console.WriteLine("la princesse te regardes dans les yeux, boom, coup de foudre, elle s'appelle Vanessa.");
                        Console.WriteLine("Ton coeur se mets à battre fort, tu connais cette sensation...");
                        Console.WriteLine("Est-ce de l'envie de tuer (1) ou de l'amour (2) ?");
                        choix = Convert.ToInt32(Console.ReadLine());

                        if (choix == 1) //Kill Princess Fin2
                        {
                            Console.Clear();
                            Console.WriteLine("Tu n'as que faire des histoires d'amour, tu lui fait le coup du lapin et rentre, du sang sur les mains");
                        }
                        else if (choix == 2) //Marry Princess Fin3
                        {
                            Console.Clear();
                            Console.WriteLine("Tu l'épouses, vous avez un mariage merveilleux, et ils vécurent heureux et urent beaucoup d'enfants...<3");
                        }
                    }



                }
                else if (choix == 2) //Kiss Witch
                {
                    Console.Clear();
                    Console.WriteLine("Tu te penches vers elle et l'embrasse gouluement, de la salive coule.");
                    Console.WriteLine("");
                    Console.WriteLine("C'est alors qu'elle se transforme en une magnifique princesse, personne ne s'y attendait");
                    Console.WriteLine("la princesse te regardes dans les yeux, boom, coup de foudre, elle s'appelle Vanessa.");
                    Console.WriteLine("Ton coeur se mets à battre fort, tu connais cette sensation...");
                    Console.WriteLine("Est-ce de l'envie de tuer (1) ou de l'amour (2) ?");
                    choix = Convert.ToInt32(Console.ReadLine());

                    if (choix == 1) //Kill Princess Fin2
                    {
                        Console.Clear();
                        Console.WriteLine("Tu n'as que faire des histoires d'amour, tu lui fait le coup du lapin et rentre, du sang sur les mains");
                    }
                    else if (choix == 2) //Marry Princess Fin3
                    {
                        Console.Clear();
                        Console.WriteLine("Tu l'épouses, vous avez un mariage merveilleux, et ils vécurent heureux et urent beaucoup d'enfants...<3");
                    }
                }



            }
            else if (choix == 2) //Portail Bleu
            {

                Console.Clear();
                Console.WriteLine("Tu entres dans le portail bleu, et une pression immense te frappe.");
                Console.WriteLine("Au fur et à mesure que tu avances, tu commences à distinguer une lumière.");
                Console.WriteLine("Tu t'en approches et au moment où tu la touches, tout autour de toi disparait.");
                Console.WriteLine("Tu flottes un instant dans le vide, avant que tout s'accélère et que tu tombe au sol.");
                Console.WriteLine("");
                Console.WriteLine("Tu es réveillé par une explosion, et des sirènes de police retentissent");
                Console.WriteLine("Il semblerait que tu sois dans une ruelle, dans une ville inconnue");
                Console.WriteLine("D'un seul coup, tu lèves les yeux et vois une affiche : Bienvenue à Gotham");
                Console.WriteLine("");
                Console.WriteLine("Alors que tu sors de la ruelle, tu entends un moteur arriver en trombe.");
                Console.WriteLine("Lorsque tu vois le mysterieux véhicule arriver, tu n'en crois pas tes yeux.");
                Console.WriteLine("Ce n'est autre que la Batmobile, elle freine d'un coup et Batman sort (si si c'est vraiment ce qu'il se passe!)");
                Console.WriteLine("<Ami (1) ou Ennemi (2) ?!> dit Batman");
                choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1) //Aide Batman
                {
                    Console.Clear();
                    Console.WriteLine("<Je suis avec toi, tu m'as l'air badass ! Quel est la situation> dit Deadpool");
                    Console.WriteLine("<L'asile d'Arkham a été détruit et tous les méchants se sont évadés ! Tu dois m'aider !> Dit Batman");
                    Console.WriteLine("Deadpool est heureux, il affiche un petit sourire en coin, dégaine son...");
                    Console.WriteLine("");
                    Console.WriteLine("SUPER FLINGUE DESTRUCTEUR DE MÉCHANTS DC COMICS (oui oui il existe, c'est moi qui le dit)");
                    Console.WriteLine("");
                    Console.WriteLine("Tu actives ton jetpack (je ne dirai pas où il l'avait rangé) et t'envoles");
                    Console.WriteLine("dans les rues de Gotham et extermine tous les méchants en quelques minutes");
                    Console.WriteLine("");

                }
                else if (choix == 2) //Tuer Batman
                {
                    Console.Clear();
                    Console.WriteLine("<Disons que c'est moi qui choisis mon camp... Et je veux ton masque !> dit Deadpool");
                    Console.WriteLine("Tu brandis ton katana et tues Batman. Il est à genou et meurt comme Marion Cotillard dans Dark Knight");
                    Console.WriteLine("<Cri** t'aurais au moins pu bien mourrir !> dit Deadpool (je suis d'accord) ");
                    Console.WriteLine("");
                    Console.WriteLine("Un nouveau justicier habite désormais Gotham et c'est une machine de guerre...(Toi)");
                    Console.WriteLine("Tu traques tous les méchants de DC Comics et les tue sans aucune pitié.");
                    Console.WriteLine("");

                }
            }

            afficherScenarioFin4();
            choix = Convert.ToInt32(Console.ReadLine());

            if (choix == 1) // Chimichangas
            {
                Console.Clear();
                Console.WriteLine("Tu pars pour aller manger des Chimichangas,");
                Console.WriteLine("Quand soudain ! Le Milano (le vaisseau des Gardiens de la Galaxie) atteri devant toi.");
                Console.WriteLine("");
                Console.WriteLine("Groot sort alors du vaisseau");
                Console.WriteLine("<Salut, je m'appelle Deadpool, et toi ?> dit Deadpool");
                Console.WriteLine("<Je s'appelle Groot, je s'appelle Groot ! Je s'appelle Groot ?>");
                Console.WriteLine("<Ah... Cool...> marmonne Deadpool");
                Console.WriteLine("<Ne fais pas attention à lui> dit Star-Lord en descandant du vaisseau");
                Console.WriteLine("<Avec les Gardiens on a pas mal réflechi, et ce serait un honneur de t'avoir dans notre équipage>");
                Console.WriteLine("C'est avec honneur que tu acceptes et rejoins les Gardiens de la Galaxie.");
                Console.WriteLine("");
                Console.WriteLine("Après avoir décollé, le vaisseau reçoit une alerte inter-galactique :");
                Console.WriteLine("<Ronan l'accusateur s'est échappé de prison, appel à tous les héros disponibles !>");
                Console.WriteLine("Les Gardiens te regardent... que veux-tu faire ?");
                Console.WriteLine("Partir botter les fesses de Ronan (1) ou activer la vitesse lumière pour faire un voyage inter-galactique (2)");
                choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1) //Fight Ronan
                {
                    Console.Clear();
                    Console.WriteLine("<Allons botter les fesses de ce schtroumpf radioactif !> dit Deadpool");
                    Console.WriteLine("");
                    Console.WriteLine("Vous partez en direction de la prison pour empêcher Ronan de semer le chaos... à nouveau.");
                    Console.WriteLine("Lorsque vous arrivez, il est déjà trop tard. La prison est en feu.");
                    Console.WriteLine("C'est alors qu'au travers des débris et des flammes, une ombre commence à se distinguer.");
                    Console.WriteLine("Marchant sur les cadavres fumants et démembrés, Ronan arrive, son marteau de guerre à la main.");
                    Console.WriteLine("");
                    Console.WriteLine("Les Gardiens sont sous le choc, Star-Lord commence à s'avancer pour se charger du meurtrier,");
                    Console.WriteLine("mais c'est alors que tu te mets devant lui :");
                    Console.WriteLine("");
                    Console.WriteLine("<C'est bon Quill, tu en a assez bavé, laisse moi m'en charger.>");
                    Console.WriteLine("Tu dois choisir la manière dont tu vas lui faire payer.");
                    Console.WriteLine("Le défies-tu en duel de danse (1) ou en guerre de pouce (2) ?");
                    choix = Convert.ToInt32(Console.ReadLine());

                    if (choix == 1) // 1v1 Ronan Danse
                    {
                        Console.Clear();
                        Console.WriteLine("La danse, ton domaine préféré, après le meurtre !");
                        Console.WriteLine("<Ok DJ, lance DMX - X Gonna Give It To Ya !> crie Deadpool en s'avançant vers Ronan");
                        Console.WriteLine("Un DJ apparait (je fais toujours ce que je veux, ok?) et lance la musique");
                        Console.WriteLine("");
                        Console.WriteLine("Tu commences alors à te déhancher, les lumières deviennent rouges et les flammes dansent.");
                        Console.WriteLine("Alors que Ronan t'observes t'approcher de lui, il commence également à danser.");
                        Console.WriteLine("");
                        Console.WriteLine("la battle de danse bat son plein, les deux danseurs sont face à face et enchainent les pas de danses.");
                        Console.WriteLine("Tu es face à Ronan et commence à marcher sur les mains et à faire tourbilloner tes jambes.");
                        Console.WriteLine("Ronan perd son calme, panique, tu danses trop bien !");
                        Console.WriteLine("");
                        Console.WriteLine("Avant même qu'il n'ait le temps de comprendre ce qu'il lui arrive, tu actives les lames cachées qui étaient dans tes chaussures ");
                        Console.WriteLine("Tu plantes ton arme secrète dans sa gorge et le laisse se vider de son sang.");
                        Console.WriteLine("");
                        Console.WriteLine("Alors que le corps de Ronan git sur le sol, les Gardiens t'applaudissent et tu fais une révérence.");
                        Console.WriteLine("Vous remontez à bord du vaisseau et partez pour de nouvelles aventures...");
                        Console.WriteLine("");
                        Console.WriteLine("(La suite au prochain numéro)");
                        Console.WriteLine("(J'ai menti)"); //Fin Ronan Mort Danse
                    }

                    else if (choix == 2) //Guerre de pouces
                    {
                        Console.Clear();
                        Console.WriteLine("Tu décides de défier Ronan en duel de guerre de pouces.");
                        Console.WriteLine("<Hé gros bleu ! Guerre des pouces, 3 manches, je t'explose !> crie Deadpool en narguant Ronan");
                        Console.WriteLine("Ronan accepte et les Gardiens vous entoure.");
                        Console.WriteLine("");
                        Console.WriteLine("Le duel bat son plein, tu as gagné la première manche et il a gagné la seconde,");
                        Console.WriteLine("La dernière manche sera décisive, le duel commence, les pouces s'entrechoquent et se ratent de peu.");
                        Console.WriteLine("Le dernier coup, sera décisif, mais cela ne sera pas ton choix, ce sera... LE DESTIN");
                        Console.WriteLine("");
                        Console.WriteLine("Appuyer sur 3 pour lancer le duel, vous avez 1 chance sur 3 de mourir. À vous de jouer.");
                        choix = Convert.ToInt32(Console.ReadLine());
                        Random aleatoire = new Random();
                        pouce = aleatoire.Next(1, 4);

                        if (pouce <= 2) //Victoire Pouce
                        {
                            Console.Clear();
                            Console.WriteLine("Tu réussis à appuyer sur le pouce de Ronan et gagne la manche !");
                            Console.WriteLine("Tu gardes ton pouce sur le pouce de Ronan, et de ton autre main dégaine ton flingue et le place sous le menton de Ronan");
                            Console.WriteLine("<Bang bang le schtroumpf> dis-tu en pressant la détente !");
                            Console.WriteLine("La cervelle de Ronan vole en éclat et il tombe au sol, inanimé.");
                            Console.WriteLine("Tu as sauvé l'univers, tu repars avec les gardiens pour de nouvelles aventures !");
                            Console.WriteLine("");
                            Console.WriteLine("(La suite au prochain numéro)(OU PAS)");
                        }
                        else //Défaite Pouce DP MEURT
                        {
                            Console.Clear();
                            Console.WriteLine("Ronan prend le dessus et appuie sur ton pouce");
                            Console.WriteLine("Il gagne, et t'écrase avec son marteau, puis tue tous les Gardiens et s'envole conquérir l'univers...");
                            Console.WriteLine("Tu as perdu loser, tu es mort loser, t'es nul loser... Loser");
                        }

                    }
                }

                else if (choix == 2) //Voyage intergalactique
                {
                    Console.Clear();
                    Console.WriteLine("Tu décides d'ignorer Ronan et de partir en vacances dans l'espace.");
                    Console.WriteLine("Tu appuies sur le bouton de vitesse lumière, t'assoies et t'attaches.");
                    Console.WriteLine("À peine tes fesses sont posées que tout autour du vaisseau s'accélère, tu es scotché à ton siège");
                    Console.WriteLine("Le Milano tremble de partout et tu vois le compteur dépasser les 2 000 000 de km/h");
                    Console.WriteLine("");
                    Console.WriteLine("Quelques instants plus tard, le vaisseau ralentit et tu appreçois l'espace, les planètes, les étoiles, c'est...");
                    Console.WriteLine("<Olala mais quel raconteur... C'est bon on s'en fiche de dehors, je veux m'amuser !> se plaint Deadpool");
                    Console.WriteLine("Ok Deadpool, voilà le plan, devant toi il y a deux galaxies, dans laquelle veux-tu aller ?");
                    Console.WriteLine("");
                    Console.WriteLine("(Attention, il pourrait PEUT ÊTRE y avoir un piège)");
                    Console.WriteLine("(Notons également que ces deux galaxies existent vraiment, j'ai bien fait mes devoirs)");
                    Console.WriteLine("<Tu t'égares vraiment là non ?> se moque Deadpool");
                    Console.WriteLine("Oui... Tu vas dans la Galaxie Sombrero (1) ou dans la Galaxie M-83 (2) ?");
                    choix = Convert.ToInt32(Console.ReadLine());

                    if (choix == 1) //Galaxie Sombrero
                    {
                        Console.Clear();
                        Console.WriteLine("Tu as choisis ça pour le nom avoue..");
                        Console.WriteLine("Vous partez tous ensemble pour la Galaxie Sombrero, et atterissez sur la première planète que vous voyez.");
                        Console.WriteLine("C'est à votre grande surprise qu'en attérissant, vous vous appercevez que les habitans ne sont autres que...");
                        Console.WriteLine("");
                        Console.WriteLine("Des Aliens Mexicains ! Il sont tout verts, mais ont tous une moustache et un sombrero sur la tête... et des maracas.");
                        Console.WriteLine("L'équipage semble effrayé et souhaite vite partir, et toi, que veux tu faire ?");
                        Console.WriteLine("Tu sens que ta vraie place est ici, pour manger des tacos et des plats mexicains pour toujours..");
                        Console.WriteLine("");
                        Console.WriteLine("Veux-tu rester ici à jamais (1) ou juste boire un verre de Tequila et repartir (2) ?");
                        choix = Convert.ToInt32(Console.ReadLine());

                        if (choix == 1) //Fin Mexicains
                        {
                            Console.Clear();
                            Console.WriteLine("Tu décides de rester vivre ici, tu dis au revoir aux Gardiens, tu te sera bien amusé");
                            Console.WriteLine("Les Aliens Mexicains sont heureux de t'accueillir ! Vous partez tous ensemble pour aller manger et boire ensemble.");
                            Console.WriteLine("C'est une belle fin n'est-ce pas ? Ça tombe bien, car c'est fini ! Félicitations");
                        }

                        else if (choix == 2) //Fin Gardiens
                        {
                            Console.Clear();
                            Console.WriteLine("Tu décides de boire quelques shots rapides.");
                            Console.WriteLine("Les Gardiens te ramassent complètement ivre et t'emmènent au vaisseau");
                            Console.WriteLine("Le Milano décole et vous partez ensemble pour de nouvelles aventures...");
                            Console.WriteLine("");
                            Console.WriteLine("(La suite au prochain épisode)");
                        }
                    }

                    else if (choix == 2) //Mort M-83 DP MEURT
                    {
                        Console.Clear();
                        Console.WriteLine("Vous arrivez dans la Galaxie M-83 et vous faites aspirer dans un trou noir, pas de chance");
                        Console.WriteLine("Vous finissez tous bloqués dans l'espace-temps et ne sortirez jamais...");
                        Console.WriteLine("FIN.");
                    }
                }
            }

            else if (choix == 2) //Tacos
            {
                Console.Clear();
                Console.WriteLine("Tu pars pour aller manger des Tacos");
                Console.WriteLine("C'est alors qu'Iron Man s'écrase devant toi. Il semble mal en point, tu ouvres son casque. Il te regarde et balbutie quelques mots :");
                Console.WriteLine("<Deadpool, c'est toi ? Oh il manquait plus que ça...> dit-il");
                Console.WriteLine("<C'est gentil, moi aussi je suis ravis de te voir la boite de conserve> réponds-tu");
                Console.WriteLine("");
                Console.WriteLine("C'est alors Captain Marvel qui atteri à une vingtaine de mètre de toi, elle peine à tenir debout et est en sang.");
                Console.WriteLine("Tu ne comprends plus rien, quand soudain, Thanos arrive à son tour avec à son poignet le gant de l'infini.");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Stark te regarde, du sang coule de son front, il te demande d'aller affronter Thanos.");
                Console.WriteLine("Il a réuni toutes les pierres d'infinités et est désormais un dieu");
                Console.WriteLine("");
                Console.WriteLine("Tous les Avengers sont tombés, il ne reste plus que Captain Marvel, et elle va avoir du mal à l'affronter seule");
                Console.WriteLine("Que faire ?");
                Console.WriteLine("Vas-tu aller affronter Thanos seul à seul (1) ou vas-tu aller soutenir Captain Marvel en t'alliant à elle (2) ?");
                choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1) //1v1 Thanos
                {
                    Console.Clear();
                    Console.WriteLine("Tu as choisi d'aller affronter Thanos en 1 contre 1, tu as vraiment des balls !");
                    Console.WriteLine("Est-ce que cela suffira-t-il ?");
                    Console.WriteLine("");
                    Console.WriteLine("Tu approches Captain Marvel qui a le genou à terre et est essouflé.");
                    Console.WriteLine("Tu passes à côté d'elle et t'approches de Thanos en te craquant les poings.");
                    Console.WriteLine("Alors que le titan te dévisage, tu commences à dégainer tes katanas...");
                    Console.WriteLine("");
                    Console.WriteLine("À peine sorti de leurs fourreaux, Thanos se téléporte devant toi et s'apprête à te frapper ");
                    Console.WriteLine("Tu tentes une esquive");
                    Console.WriteLine("(Appuyer sur 3 pour tenter d'esquiver)");
                    choix = Convert.ToInt32(Console.ReadLine());
                    Random aleatoire = new Random();
                    esquive = aleatoire.Next(1, 6);

                    if (esquive <= 2) //Victoire Thanos
                    {
                        Console.Clear();
                        Console.WriteLine("Tu as réussi à esquiver de peu et lui tranche le bras avant de récuperer le gant et de l'équiper.");
                        Console.WriteLine("Alors que Thanos tient son moignon et se plie de douleurs, tu reviens à la charge");
                        Console.WriteLine("Tu actives toutes les pierres d'un coup, fermes ton poings, et lui décoche un uppercut monumental.");
                        Console.WriteLine("Le sol tremble, le ciel devient noir, et tout autour de toi se fracture.");
                        Console.WriteLine("Quand à Thanos, il est réduit à néant et n'est désormais qu'un tas de poussière.");
                        Console.WriteLine("");
                        Console.WriteLine("la victoire est tienne, tu as réussi a vaincre l'immense Titan.");
                        Console.WriteLine("tu repars pour aller manger tes tacos.");
                        Console.WriteLine("FIN.");
                    }

                    else //Défaite DP MEURT
                    {
                        Console.Clear();
                        Console.WriteLine("Tu n'as pas le temps d'esquiver et Thanos te frappe en pleine tête.");
                        Console.WriteLine("Ta tête vole et se désintègre.");
                        Console.WriteLine("Pas besoin d'être un génie pour comprendre que tu es mort.");
                        Console.WriteLine("(Quelle idée d'aller affronter Thanos tout seul en même temps)");
                    }
                }

                else if (choix == 2) //DP et CM
                {
                    Console.Clear();
                    Console.WriteLine("Tu cours vers Captain Marvel et l'aide à tenir debout.");
                    Console.WriteLine("<Deadpool, c'est toi ? Oh je t'en prie tu dois nous aider, il est inarretable.> dit-elle");
                    Console.WriteLine("<Tu peux compter sur moi Captain Marvel ! Un plan d'attaque ?> lui réponds-tu");
                    Console.WriteLine("<Toute sa puissance repose dans son gant, une fois enlevé je peux m'en charger> dit Cap' Marvel");
                    Console.WriteLine("");
                    Console.WriteLine("...");
                    Console.WriteLine("");
                    Console.WriteLine("Il semblerait que tu aies un plan, vas-tu l'attaquer avec tes katanas (1) ou as tu les balls d'y aller mains nues (2) ?");
                    choix = Convert.ToInt32(Console.ReadLine());

                    if (choix == 1) //Thanos Katanas
                    {

                        Console.Clear();
                        Console.WriteLine("Tu cours sur Thanos avec les katanas dégainés, alors qu'il s'apprête à te frapper, tu esquives et glisses sous ses jambes.");
                        Console.WriteLine("Il n'a même pas le temps de se retourner que tu lui tranche le bras sur lequel était le gant.");
                        Console.WriteLine("");
                        Console.WriteLine("Captain Marvel en profite pour lui plonger dessus et le frapper à pleine puissance.");
                        Console.WriteLine("Sa tête explose et du sang violet gicle partout, il tombe inanimé au sol.");
                        Console.WriteLine("Captain Marvel te remercie et te proposes d'integrer les Avengers, tu as prouvé ta bravoure.");
                        Console.WriteLine("");
                        Console.WriteLine("Tu deviens désormais Deadpool l'Avenger et en profite pour avoir Tacos à volonté et gratuits pour le reste de tes jours.");
                        Console.WriteLine("FIN.");
                    }
                    else if (choix == 2) //Mains Nues
                    {
                        Console.Clear();
                        Console.WriteLine("Tu te décides à y aller à mains nues. Tu te sens fougeux.");
                        Console.WriteLine("Thanos active la pierre de la réalité pour te paralyser et te transformer en Licore pour le restant de tes jours.");
                        Console.WriteLine("Captain Marvel observe le triste spectacle et se rend à l'évidence, c'est fini...");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Mais soudain, Licorne-Pool plante sa corne dans le crâne de Thanos qui meurt instantanément.");
                        Console.WriteLine("");
                        Console.WriteLine("Captain Marvel n'en croit pas ses yeux, Licorne-Pool a sauvé le monde de Thanos.");
                        Console.WriteLine("(Pas très réaliste comme fin, mais je fais ce que je veux ! Oh et Licorne-Pool intègre les Avengers, voilà je décide !)");
                        Console.WriteLine("(Et Licorne-Pool devient même président des USA)");
                        Console.WriteLine("");
                        Console.WriteLine("...");
                        Console.WriteLine("");
                        Console.WriteLine("Voilà... FIN.");
                    }
                }
            }



            Console.ReadKey();






            //FIN
        }

        static public void afficherScenarioSortie()
        {
            Console.WriteLine("");
            Console.WriteLine("Tu saute par la fenêtre du 7ème étage et atteri comme une crêpe");
            Console.WriteLine("Tu attends 1h le temps que ton corps ce régénère et tu te relèves");
            Console.WriteLine("");
            Console.WriteLine("Tu regardes le ciel,il est bleu, c'est un beau temps pour tuer des gens");
            Console.WriteLine("");
            Console.WriteLine("(Après tout, n'importe quel temps est bon pour tuer, tu le sais !)");
            Console.WriteLine("Deadpool brise le 4ème mur : <Bon, t'as fini ? On peut continuer l'histoire ?!>");
            Console.WriteLine("Oui, reprenons Deadpool, tu veux aller marcher un peu ? (1) ou prendre un taxi ? (2)");
        }

        static public void afficherScenarioPortail()
        {
            Console.WriteLine("");
            Console.WriteLine("Tu décides de t'approcher de l'immense porte et observe quelque chose d'étrange");
            Console.WriteLine("Il semblerait que deux lueurs scintillent et s'échappent de la grande porte, une verte et une bleue...");
            Console.WriteLine("Tu sembles intrigé et t'approches doucement de ces lueurs. Il semblerait que ce soit des portails. Tu...");
            Console.WriteLine("");
            Console.WriteLine("<Hé, tu t'égares encore ! C'est des portails, maintenant laisse moi rentrer dedans !> dit Deadpool");
            Console.WriteLine("Ok Deadpool, tu vas dans lequel, le portail vert, d'où se dégage une odeur boisée (1)");
            Console.WriteLine("Ou le portail bleu, qui semble étrangement rater toutes ses tentatives au cinéma (2) ?");
        }
        static public void afficherScenarioSorcière()
        {
            Console.WriteLine("");
            Console.WriteLine("Tu pourchasses la sorcière pendant pas très longtemps");
            Console.WriteLine("Alors qu'elle courait, elle a trébuchée dans sa robe et est tombée.");
            Console.WriteLine("Deux choix s'offrent alors à toi, soit tu la tue (1) soit tu l'embrasse (2)");
            Console.WriteLine("Je t'assure qu'elle est vraiment très laide ! Affreuse, mais bon... qui sait.");
        }
        static public void afficherScenarioFin4()
        {
            Console.WriteLine("");
            Console.WriteLine("Tu es désormais surpuissant, et tu finis par vite t'ennuyer");
            Console.WriteLine("Tu décides alors de détruire entièrement l'univers DC, que dis-je, tu l'annihilies totalement.");
            Console.WriteLine("Il est pas génial de toute façon, une fois l'univers anéantis, tu rentres dans l'univers Marvel.");
            Console.WriteLine("");
            Console.WriteLine("Une semaine s'est écoulé depuis ton aventure, tu décides d'aller manger car tu as faim (étonnant hein ?).");
            Console.WriteLine("Veux-tu manger des Chimichangas (1) ou des Tacos (2) ?");
        }
    }
}

