using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace enroute.Pages;

public class Youtubers
{
    public string Name { get; set; }
    public string ChanelUrl { get; set; }
    public string Intro { get; set; }
    public class VideoCategories
    {
        public string Title { get; set; }
        public string VideoTitle { get; set; }
        public string videoSrc { get; set; }
        public string text { get; set; }
    }
    public List<VideoCategories> Categories = new List<VideoCategories>();
}

public class YoutubersModel : PageModel
{
    public List<Youtubers> youtubers = new List<Youtubers>();
    public List<Youtubers> getYoutubers()
    {
        return youtubers;
    }
    public YoutubersModel()
    {
        youtubers.Add
        (
            new Youtubers()
            {
                Name = "Japania",
                ChanelUrl = "https://www.youtube.com/c/JapaniaTV",
                Intro = "Amine, (Japania), t'amène à découvrir le Japon depuis le point de vue des locaux et un ou un autre expatrié",
                Categories = new List<Youtubers.VideoCategories>()
                {
                    new Youtubers.VideoCategories()
                    {
                        Title = "Interviews de Japonais !",
                        VideoTitle = "La Drague au Japon: une réalité totalement méconnue",
                        videoSrc = "https://www.youtube.com/embed/cGOmCkPuk9g?list=PLfOX4Qf9RTtzMXY5VaMTJP4ZrrFz87s7_",
                        text = "Qu'est-ce que choque les japonais des habitudes des étrangères ? Qu'est-ce que c'est la culture de la drague aux rues ? Quelles sont les critères de beauté chez les japonais ? Comment ils perçoivent les relationes amoureuses ? Quelle est leur concepcion de l'infidelité?" + "<br> <br>" + "Amine parcours les rues de Tokyo (majoritairement) en demandent aux japonais son avis à propos des sujets divers. Ces  interviews exposent des points de la culture japonaises méconnues à l'étranger, et aussi les points de vue des japonais sur le monde."
                    },
                    new Youtubers.VideoCategories()
                    {
                        Title = "Le Monde de la Nuit au Japon",
                        VideoTitle = "La vie d'une Pʀᴏꜱᴛɪᴛᴜᴇ́ᴇ​​ au Japon ! (Attention c'est sombre...)",
                        videoSrc = "https://www.youtube.com/embed/YR5u0OVZ06E?list=PLfOX4Qf9RTty0joTNIwZiJVMrbNsBPV5O",
                        text = "C'est quoi le monde de la nuit au Japon ? Quelles sont les métiers plus populaires dans ce monde et qu'est que ce cache desuss ? Quelles sont les dangers pour ceux qui tombe sur ses « pièges »  ? A quoi ressemble la vie de quelqu'un qui y travaille ?" + "<br> <br>" + "Le monde de la nuit au Japon (surtout à Tokyo) est un sujet tellement complexe que mértite sa prope catégorie. À travers des micro-trottoirs, des interviews ou même en tentant l'expérience par lui-même, Amine nous emmène à la découverte de ce côté « sombre » du Japon."
                    },
                    new Youtubers.VideoCategories()
                    {
                        Title = "Voyage et Aventure au Japon",
                        VideoTitle = "10 000 Yen à Ueno !",
                        videoSrc = "https://www.youtube.com/embed/a-etwtHedTI?list=PLfOX4Qf9RTtyMjMIPIvrh38vxXXAZXC_o",
                        text = "Où et quand profiter de la neige au Japon ? Où se trouve la meillure piste cyclable du pais ? Et les mellieures Onsen ? Qu'est qu'il a à faire dans la region du Monte Fuji ? Pourquoi on devrait (absolument) visiter le centre du Japon ?" + "<br> <br>" + "Tokyo n'est pas le Japon! ou plutôt, ce n'est pas tout. Amine nous emmène à la découverte du Japon dehors de Tokyo. En passant par le nord, centre et sud du pais, Amine mange des repas délicieux, fait des rencontres inattendues et des experience inoubliables."
                    }
                }
            }
        );
        youtubers.Add
        (
            new Youtubers()
            {
                Name = "Louis-San",
                ChanelUrl = "https://www.youtube.com/c/LouisSan",
                Intro = "Louis Zenjas (Louis-San), t'amène à découvrir le Japon depuis le point de vue d'un métis franco-japonais.",
                Categories = new List<Youtubers.VideoCategories>()
                {
                    new Youtubers.VideoCategories()
                    {
                        Title = "Japon (日本)",
                        VideoTitle = "4 choses que les Japonais(es) envient chez les étrangers",
                        videoSrc = "https://www.youtube.com/embed/kNUpPeCwol8?list=PL6kP02_NV5msIa_9YsW4djoKJK1aN0De9",
                        text = "Qu'est-ce que est illégal au Japon mais pas au France ? Qu'est-ce que les japonais envie chez les étrangeres ? C'est quoi les love hôtels? Les maid café ? Être gros au Japon c'est illégal ? À quoi ressemble la journée dans la vie d'un chef de ramen ?" + "<br> <br>" + "Le Japon démystifié par quelqu'en de heritage japonais. Parfois sur place, parfois depuis son studio, parfois avec de français, parfois avec de japonaises, Louis nous parle de son coté japonais et des diverses realités du pais qui diffèrent à celles de la France "
                    },
                    new Youtubers.VideoCategories()
                    {
                        Title = "Horreur",
                        VideoTitle = "L'homme qui a volé 10 millions d'€ au Japon (fait réel)",
                        videoSrc = "https://www.youtube.com/embed/5mTPi-POT7A?list=PL6kP02_NV5mvUCO1sBvndGby4fEOVRL4g",
                        text = "Comment qu'ulqun a pu voler 10 millions de euros au Japon? Comment une fille de 11 ans a arrêté à le criminel le plus recherché au pais ? Quelle est la prise d'otage ou le prison break la plus incroyable qui se soit produit dans le pais ?" + "<br> <br>" + "En enquêtant sur des documents historiques, en reliant des points qui ne sont pas toujours évidents, en comprenant le pourquoi de ces événements, et avec une style de narration qui donne de frissons, Louis partage avec nous sa passion pour ce genre d'histoires"
                    },
                    new Youtubers.VideoCategories()
                    {
                        Title = "Le bon blogs",
                        VideoTitle = "48H à Okinawa (un Japon tropical que vous ne connaissez pas)",
                        videoSrc = "https://www.youtube.com/embed/ow1yG5br9hw?list=PL6kP02_NV5muPIaPQcaGRXMii6aKKCN1M",
                        text = "Pourquoi Okinawa est si éspecial est différent du reste du Japon ? Quelles sont les activités incontournables à faire à Tokyo ? Quelles particuliarités les gens qui ont de tatouages au Japon ? À qoui ressemble une soirée avec une Geisha à Fukushima ?" + "<br> <br>" + "À le style des blogs, parfois à Tokyo, parfois dans les régions, Louis sors de son studio pour parfois nous emmèner à découvrir des éxperiences sur place et parfois pour interviewer à des gens qui vivent ou ont vécus d'autres tout aussi intéressentes"
                    }
                }
            }
        );
        youtubers.Add
        (
            new Youtubers()
            {
                Name = "Ichiban-Japan",
                ChanelUrl = "https://www.youtube.com/c/IchibanJapan",
                Intro = "Guigui (Ichiban-Japan), t'amène à découvrir le Japon traditionnel à travers des aventures sur place en traitant des sujets passionants",
                Categories = new List<Youtubers.VideoCategories>()
                {
                    new Youtubers.VideoCategories()
                    {
                        Title = "Le Japon en immersion",
                        VideoTitle = "Une journée dans un lycée pour filles au Japon",
                        videoSrc = "https://www.youtube.com/embed/5ej0C0O93y8?list=PLAn2TkVtvvkQiVgthlxULF7vIB93LGZG4",
                        text = "Qu'est-ce que est illégal au Japon mais pas au France ? Qu'est-ce que les japonais envie chez les étrangeres ? C'est quoi les love hôtels? Les maid café ? Être gros au Japon c'est illégal ? À quoi ressemble la journée dans la vie d'un chef de ramen ?" + "<br> <br>" + "Le Japon démystifié par quelqu'en de heritage japonais. Parfois sur place, parfois depuis son studio, parfois avec de français, parfois avec de japonaises, Louis nous parle de son coté japonais et des diverses realités du pais qui diffèrent à celles de la France "
                    },
                    new Youtubers.VideoCategories()
                    {
                        Title = "Short Stories",
                        VideoTitle = "GUNMA, le paradis des Onsen",
                        videoSrc = "https://www.youtube.com/embed/rJq-LZWieGA?list=PLAn2TkVtvvkTXqbE0Ym8YjU4VUEAwtq7B",
                        text = "Comment qu'ulqun a pu voler 10 millions de euros au Japon? Comment une fille de 11 ans a arrêté à le criminel le plus recherché au pais ? Quelle est la prise d'otage ou le prison break la plus incroyable qui se soit produit dans le pais ?" + "<br> <br>" + "En enquêtant sur des documents historiques, en reliant des points qui ne sont pas toujours évidents, en comprenant le pourquoi de ces événements, et avec une style de narration qui donne de frissons, Louis partage avec nous sa passion pour ce genre d'histoires"
                    },
                    new Youtubers.VideoCategories()
                    {
                        Title = "Tranches de vie",
                        VideoTitle = "KAWASAKI, la ville de Naoki",
                        videoSrc = "https://www.youtube.com/embed/OciQ-naOfAQ?list=PLAn2TkVtvvkSyaoQ3tZnINrWhDc82m6Qf",
                        text = "Pourquoi Okinawa est si éspecial est différent du reste du Japon ? Quelles sont les activités incontournables à faire à Tokyo ? Quelles particuliarités les gens qui ont de tatouages au Japon ? À qoui ressemble une soirée avec une Geisha à Fukushima ?" + "<br> <br>" + "À le style des blogs, parfois à Tokyo, parfois dans les régions, Louis sors de son studio pour parfois nous emmèner à découvrir des éxperiences sur place et parfois pour interviewer à des gens qui vivent ou ont vécus d'autres tout aussi intéressentes"
                    }
                }
            }
        );
        youtubers.Add
        (
            new Youtubers()
            {
                Name = "Tev-Ici-Japon",
                ChanelUrl = "https://www.youtube.com/user/IciJapon",
                Intro = "Tev t'amène à découvrir le Japon depuis le point de vue d'un entrepreneur et vidéaste vivant au Japon depuis 2011",
                Categories = new List<Youtubers.VideoCategories>()
                {
                    new Youtubers.VideoCategories()
                    {
                        Title = "WTF Japan",
                        VideoTitle = "Les Hosts (ne tombez pas dans le piège)",
                        videoSrc = "https://www.youtube.com/embed/rZoQEQ3yOYI?list=PLxCECXRIGBxpAky7N1e_j5VfD0-MjSNwi",
                        text = "Quelles sont les « pièges » des Host au Japon ? Quel est le côté sombre de la industrie des idoles ? Quelle image ont les japonais de l'alcool ? Qu'y a-t'il d'éspecial sur l'uniforme au Japon ? À quoi ressemblent les excentricités chez les politiciens japonais ?" + "<br> <br>" + "Tev il présente le côté wtf de Japon démystifié par quelqu'en de heritage japonais. Parfois sur place, parfois depuis son studio, parfois avec de français, parfois avec de japonaises, Louis nous parle de son coté japonais et des diverses realités du pais qui diffèrent à celles de la France "
                    },
                    new Youtubers.VideoCategories()
                    {
                        Title = "Japon",
                        VideoTitle = "Dans un capsule hotel",
                        videoSrc = "https://www.youtube.com/embed/BeRSDWO6gs4?list=PLxCECXRIGBxraftXD11BcMDzcgn2rMEMw",
                        text = "Comment qu'ulqun a pu voler 10 millions de euros au Japon? Comment une fille de 11 ans a arrêté à le criminel le plus recherché au pais ? Quelle est la prise d'otage ou le prison break la plus incroyable qui se soit produit dans le pais ?" + "<br> <br>" + "En enquêtant sur des documents historiques, en reliant des points qui ne sont pas toujours évidents, en comprenant le pourquoi de ces événements, et avec une style de narration qui donne de frissons, Louis partage avec nous sa passion pour ce genre d'histoires"
                    },
                    new Youtubers.VideoCategories()
                    {
                        Title = "Xsite",
                        VideoTitle = "L'étrange station de ski abandonnée",
                        videoSrc = "https://www.youtube.com/embed/KP-WBsUWcGY?list=PLxCECXRIGBxp0Dbz_gvIcxrhypoTJ169G",
                        text = "Pourquoi Okinawa est si éspecial est différent du reste du Japon ? Quelles sont les activités incontournables à faire à Tokyo ? Quelles particuliarités les gens qui ont de tatouages au Japon ? À qoui ressemble une soirée avec une Geisha à Fukushima ?" + "<br> <br>" + "À le style des blogs, parfois à Tokyo, parfois dans les régions, Louis sors de son studio pour parfois nous emmèner à découvrir des éxperiences sur place et parfois pour interviewer à des gens qui vivent ou ont vécus d'autres tout aussi intéressentes"
                    }
                }
            }
        );
    }
    public IActionResult OnGet()
    {
        if (youtubers == null)
        {
            return NotFound();
        }

        return Page();
    }
}