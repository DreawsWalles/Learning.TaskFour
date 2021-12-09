﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Help;

namespace RepositoryLib.XMLRepository
{
    public class XMLAphorismsRepository : IRepository
    {
        public XMLAphorismsRepository()
        {
            if (!Directory.Exists("XMLRepository"))
                Directory.CreateDirectory("XMLRepository");
            if (!File.Exists("XMLRepository/Aphorisms"))
            {
                string[] parametrs = new string[]
                {
                    "Драгоценный камень нельзя отполировать без трения. Также и человек не может стать успешным без достаточного количества трудных попыток.",
                    "Если тебе плюют в спину — значит ты идешь впереди.",
                    "Если в человеке естество затмит воспитанность, получится дикарь, а если воспитанность затмит естество, получится знаток писаний. Лишь тот, в ком естество и воспитанность пребывают в равновесии, может считаться достойным мужем.",
                    "Как мы можем знать, что такое смерть, когда мы не знаем еще, что такое жизнь?",
                    "Мудрый человек не делает другим того, чего он не желает, чтобы ему сделали",
                    "Не беспокойся о том, что тебя не знают. Беспокойся о том, достоин ли ты того, чтобы тебя знали.",
                    "Не поговорить с человеком, который достоин разговора, значит потерять человека. А говорить с человеком, который разговора не достоин, — значит терять слова. Мудрый не теряет ни людей, ни слов",
                    "Порой мы видим многое, но не замечаем главного.",
                    "Три пути ведут к знанию: путь размышления — это путь самый благородный, путь подражания — это путь самый лёгкий и путь опыта — это путь самый горький",
                    "Я не понимаю, как можно иметь дело с человеком, которому нельзя доверять? Если в повозке нет оси, как можно на ней ездить?",
                    "Учитесь так, словно вы постоянно ощущаете нехватку своих знаний, и так, словно вы постоянно боитесь растерять свои знания.",
                    "Когда, совершив ошибку, не исправил ее, это и называется совершить ошибку.",
                    "Учение без размышления бесполезно, но и размышление без учения опасно.",
                    "Не тот велик, кто никогда не падал, а тот велик — кто падал и вставал.",
                    "Красота есть во всем, но не всем дано это видеть.",
                    "Благородный человек предъявляет требования к себе, низкий человек предъявляет требования к другим.",
                    "На самом деле, жизнь проста, но мы настойчиво её усложняем.",
                    "Счастье — это когда тебя понимают, большое счастье — это когда тебя любят, настоящее счастье — это когда любишь ты.",
                    "Давай наставления только тому, кто ищет знаний, обнаружив свое невежество.",
                    "Если ты ненавидишь — значит тебя победили."
                };
                XmlFiles.Create(parametrs, "XMLRepository/Aphorisms");
            }
        }
        public void Add(AskModel model)
        {
            XmlFiles.Add(model, "XMLRepository/Aphorisms");
        }

        public string Get(int id)
        {
            return XmlFiles.Get(id, "XMLRepository/Aphorisms");
        }
    }
}