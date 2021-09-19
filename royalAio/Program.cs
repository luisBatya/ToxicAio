using System;
using System.Net;
using EnsoulSharp;
using EnsoulSharp.SDK;
using royalAio.Champions;

namespace royalAio
{

    public class Program
    {

        public static void Main(string[] args)
        {
            GameEvent.OnGameLoad += OnLoadingComplete;
        }

        private static void OnLoadingComplete()
        {
            if (ObjectManager.Player == null)
                return;
            try
            {
                switch (GameObjects.Player.CharacterName)
                {
                    
                    case "Annie":
                        Annie.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;

                    case "Ashe":
                        Ashe.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;

                    case "Blitzcrank":
                        Blitzcrank.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;

                    case "Brand":
                        Brand.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;

                    case "Kassadin":
                        Kassadin.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;

                    case "Khazix":
                        Khazix.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;

                    case "Kindred":
                        Kindred.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;

                    case "KogMaw":
                        KogMaw.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;

                    case "Morgana":
                        Morgana.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;

                    case "Rengar":
                        Rengar.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;

                    case "Tryndamere":
                        Tryndamere.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;
                    
                    case "Vladimir":
                        Vladimir.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;
                    
                    case "Ziggs":
                        Ziggs.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;
                    
                    case "Yone":
                        Yone.OnGameLoad();
                        Game.Print("<font color='#f49ac1' size='25'> [royalAio]:  </font>" + ObjectManager.Player.CharacterName + " Loaded");
                        Game.Print("<font color='#4bbdfa' size='25'> [royalAio]:  </font>" + "<font color='#efad5f' size='25'> By royalFunction team </font>");
                        break;

                    default:
                        Game.Print("<font color='#f49ac1' size='25'>[royalAio] Does Not Support :" + ObjectManager.Player.CharacterName + "</font>");
                        break;

                }
                string stringg;
                string uri = "https://raw.githubusercontent.com/luisBatya/royalAio/main/version.txt";
                using (WebClient client = new WebClient())
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    stringg = client.DownloadString(uri);
                }
                string versionas = "1.0.0\n";
                if (versionas != stringg)
                {
                    Game.Print("<font color='#f49ac1'> [royalAio]: </font> <font color='#d75959' size='25'>You don't have the current version, please update royalAio!</font>");
                }
                else if (versionas == stringg)
                {
                    Game.Print("<font color='#f49ac1' size='25'> [royalAio]: </font> <font color='#ffe6ff' size='25'>Is updated to the latest version!</font>");
                }
            }
            catch (Exception ex)
            {
                Game.Print("<font color='#f49ac1'> [royalAio]: </font> <font color='#d75959' size='25'>Error in loading</font>");
            }
        }
    }
}
