using YGOSharp.OCGWrapper;
using YGOSharp.OCGWrapper.Enums;
using System.Collections.Generic;
using System.Linq;
using System;
using WindBot;
using WindBot.Game;
using WindBot.Game.AI;
using System.Web.UI.WebControls;
using System.Text;
using System.Web.UI;

namespace WindBot.Game.AI.Decks
{
    [Deck("Branded", "AI_Branded")]
    public class BrandedExecutor : DefaultExecutor
    {
        public class CardId
        {
            public const int TheBystialLubellion = 32731036;
            public const int AlbionTheShroudedDragon = 25451383;
            public const int BystialSaronir = 60242223;
            public const int AluberTheJesterOfDespia = 62962630;
            public const int FallenOfAlbaz = 68468459;
            public const int SpringansKitt = 45484331;
            public const int GuidingQuemTheVirtuous = 45883110;
            public const int BlazingCartesiaTheVirtuous = 95515789;
            public const int TriBrigadeMercourier = 19096726;
            // _CardId.AshBlossom = 14558127;
            // _CardId.MaxxC = 23434538;
            public const int DespianTragedy = 36577931;

            public const int NadirServant = 1984618;
            public const int FusionDeployment = 6498706;
            public const int BrandedInWhite = 34995106;
            public const int BrandedFusion = 44362883;
            public const int GoldSarcophagus = 75500286;
            public const int FoolishBurial = 81439173;
            // _CardId.CalledByTheGrave = 24224830;
            public const int BrandedInHighSpirits = 29948294;
            public const int BrandedOpening = 36637374;
            // _CardId.CrossoutDesignator = 65681983;
            public const int BrandedInRed = 82738008;
            public const int BrandedLost = 18973184;

            // _CardId.InfiniteImpermanence = 10045474;
            public const int BrightestBlazingBrandedKing = 19271881;
            public const int BrandedBeast = 32756828;
            public const int BrandedRetribution = 17751597;

            public const int GuardianChimera = 11321089;
            public const int AlbionTheSanctifireDragon = 38811586;
            public const int MirrorjadeTheIcebladeDragon = 44146295;
            public const int BorreloadFuriousDragon = 92892239;
            public const int LubellionTheSearingDragon = 70534340;
            public const int AlbaLenatusTheAbyssDragon = 3410461;
            public const int GranguignolTheDuskDragon = 24915933;
            public const int DespianQuaeritis = 72272462;
            public const int SprindTheIrondashDragon = 1906812;
            public const int TitanikladTheAshDragon = 41373230;
            public const int RindbrummTheStrikingDragon = 51409648;
            public const int AlbionTheBrandedDragon = 87746184;
            public const int DespianLuluwalilith = 53971455;

            public const int NaturalExterio = 99916754;
            public const int NaturalBeast = 33198837;
            public const int ImperialOrder = 61740673;
            public const int SwordsmanLV7 = 37267041;
            public const int RoyalDecree = 51452091;
            public const int Number41BagooskatheTerriblyTiredTapir = 90590303;
            public const int InspectorBoarder = 15397015;
            public const int SkillDrain = 82732705;

            public const int DimensionShifter = 91800273;
            public const int MacroCosmos = 30241314;
            public const int DimensionalFissure = 81674782;
            public const int BanisheroftheRadiance = 94853057;
            public const int BanisheroftheLight = 61528025;
            public const int KashtiraAriseHeart = 48626373;
            public const int AccesscodeTalker = 86066372;
            public const int GhostMournerMoonlitChill = 52038441;
        }

        public BrandedExecutor(GameAI ai, Duel duel)
            : base(ai, duel)
        {
            AddExecutor(ExecutorType.Activate, _CardId.MaxxC, MaxxCActivate);

            // 
            AddExecutor(ExecutorType.SpSummon, CardId.AlbaLenatusTheAbyssDragon, AlbaLenatusTheAbyssDragonSpSummon);
            AddExecutor(ExecutorType.MonsterSet, CardId.FallenOfAlbaz, FallenOfAlbazSet);

            // quick effect
            AddExecutor(ExecutorType.Activate, CardId.BrandedRetribution, BrandedRetributionActivate);
            AddExecutor(ExecutorType.Activate, _CardId.CalledByTheGrave, CalledbytheGraveActivate);
            AddExecutor(ExecutorType.Activate, _CardId.CrossoutDesignator, CrossoutDesignatorActivate);
            AddExecutor(ExecutorType.Activate, _CardId.AshBlossom, AshBlossomActivate);
            AddExecutor(ExecutorType.Activate, _CardId.InfiniteImpermanence, InfiniteImpermanenceActivate);
            AddExecutor(ExecutorType.Activate, CardId.BrightestBlazingBrandedKing, BrightestBlazingBrandedKingActivate);
            AddExecutor(ExecutorType.Activate, CardId.BrandedOpening, BrandedOpeningActivate);
            AddExecutor(ExecutorType.Activate, CardId.BrandedInHighSpirits, BrandedInHighSpiritsActivate);

            // remove
            AddExecutor(ExecutorType.Activate, CardId.GuardianChimera, GuardianChimeraActivate);
            AddExecutor(ExecutorType.Activate, CardId.BrandedBeast, BrandedBeastActivate);
            AddExecutor(ExecutorType.Activate, CardId.BorreloadFuriousDragon, BorreloadFuriousDragonActivate);
            AddExecutor(ExecutorType.Activate, CardId.MirrorjadeTheIcebladeDragon, MirrorjadeTheIcebladeDragonActivate);

            // search
            AddExecutor(ExecutorType.Activate, CardId.TheBystialLubellion, TheBystialLubellionActivate);
            AddExecutor(ExecutorType.SpSummon, CardId.TheBystialLubellion, TheBystialLubellionSpSummon);
            AddExecutor(ExecutorType.Activate, CardId.FoolishBurial, FoolishBurialActivate);
            AddExecutor(ExecutorType.Activate, CardId.GoldSarcophagus, GoldSarcophagusActivate);
            AddExecutor(ExecutorType.Activate, CardId.AluberTheJesterOfDespia, AluberTheJesterOfDespiaActivate);
            AddExecutor(ExecutorType.Activate, CardId.DespianTragedy, DespianTragedyActivate);

            // blazing
            AddExecutor(ExecutorType.Activate, CardId.FusionDeployment, FusionDeploymentActivate);
            AddExecutor(ExecutorType.Activate, CardId.BlazingCartesiaTheVirtuous, BlazingCartesiaTheVirtuousActivate);

            AddExecutor(ExecutorType.Activate, CardId.AlbionTheShroudedDragon, AlbionTheShroudedDragonActivate);
            AddExecutor(ExecutorType.Activate, CardId.BystialSaronir, BystialSaronirActivate);

            // fusion & lost
            AddExecutor(ExecutorType.Activate, CardId.AlbionTheBrandedDragon, AlbaLenatusTheAbyssDragonActivate);
            AddExecutor(ExecutorType.Activate, CardId.LubellionTheSearingDragon, LubellionTheSearingDragonActivate);
            AddExecutor(ExecutorType.Activate, CardId.BrandedLost, BrandedLostActivate);
            AddExecutor(ExecutorType.Activate, CardId.FallenOfAlbaz, FallenOfAlbazActivate);
            AddExecutor(ExecutorType.Activate, CardId.BrandedFusion, BrandedFusionActivate);
            AddExecutor(ExecutorType.Activate, CardId.BrandedInWhite, BrandedInWhiteActivate);
            AddExecutor(ExecutorType.Activate, CardId.BrandedInRed, BrandedInRedActivate);

            // summon for search
            AddExecutor(ExecutorType.Summon, CardId.AluberTheJesterOfDespia, AluberTheJesterOfDespiaSummon);
            AddExecutor(ExecutorType.Summon, CardId.GuidingQuemTheVirtuous, GuidingQuemTheVirtuousSummonForSearch);
            AddExecutor(ExecutorType.Activate, CardId.SpringansKitt, SpringansKittActivate);
            AddExecutor(ExecutorType.Summon, CardId.SpringansKitt, SpringansKittSummon);

            // albaz summon
            AddExecutor(ExecutorType.Summon, CardId.FallenOfAlbaz, FallenOfAlbazSummon);

            AddExecutor(ExecutorType.Activate, CardId.NadirServant, NadirServantActivate);

            // delay
            AddExecutor(ExecutorType.Repos, DefaultMonsterRepos);
            AddExecutor(ExecutorType.SpellSet, SpellSetCheck);
            AddExecutor(ExecutorType.Activate, CardId.GuidingQuemTheVirtuous, GuidingQuemTheVirtuousActivate);
            AddExecutor(ExecutorType.Activate, CardId.DespianLuluwalilith, DespianLuluwalilithActivate);

        }

        const int SetcodeTimeLord = 0x4a;
        const int SetcodePhantom = 0xdb;
        const int SetcodeOrcust = 0x11b;
        const int SetcodeHorus = 0x19d;
        const int hintTimingMainEnd = 0x4;
        const int hintBattleStart = 0x8;
        List<int> notToNegateIdList = new List<int>{
            58699500, 20343502
        };
        List<int> cannotBeFusionMaterialIdList = new List<int>
        {
            CardId.AlbaLenatusTheAbyssDragon, CardId.AlbionTheSanctifireDragon, 79229522, 65029288, 30864377, 33964637, 87116928, 13735899, 28226490, 80453041
        };
        List<int> albazFusionMonster = new List<int>
        {
            CardId.TitanikladTheAshDragon, CardId.SprindTheIrondashDragon, CardId.AlbionTheBrandedDragon, CardId.LubellionTheSearingDragon, CardId.AlbaLenatusTheAbyssDragon,
            CardId.MirrorjadeTheIcebladeDragon, CardId.RindbrummTheStrikingDragon, CardId.AlbionTheSanctifireDragon
        };
        Dictionary<int, List<int>> DeckCountTable = new Dictionary<int, List<int>>{
            {3, new List<int> { CardId.AluberTheJesterOfDespia, _CardId.AshBlossom, _CardId.MaxxC, _CardId.InfiniteImpermanence }},
            {2, new List<int> { CardId.FallenOfAlbaz, CardId.NadirServant, CardId.FusionDeployment, _CardId.CalledByTheGrave }},
            {1, new List<int> { CardId.TheBystialLubellion, CardId.AlbionTheShroudedDragon, CardId.BystialSaronir, CardId.SpringansKitt, CardId.GuidingQuemTheVirtuous,
                                CardId.BlazingCartesiaTheVirtuous, CardId.TriBrigadeMercourier, CardId.DespianTragedy, CardId.BrandedInWhite,
                                CardId.BrandedFusion, CardId.GoldSarcophagus, CardId.FoolishBurial, CardId.BrandedInHighSpirits, CardId.BrandedOpening,
                                _CardId.CrossoutDesignator, CardId.BrandedInRed, CardId.BrandedLost, CardId.BrightestBlazingBrandedKing,
                                CardId.BrandedBeast, CardId.BrandedRetribution }}
        };
        List<int> dangerousDragonIdList = new List<int> { 27548199, 92892239, 98630720, 9753964, 99585850, 24361622, 27572350, 69120785 };

        bool summoned = false;
        bool enemyActivateMaxxC = false;
        bool enemyActivateLockBird = false;
        int dimensionShifterCount = 0;
        bool enemyActivateInfiniteImpermanenceFromHand = false;
        bool theBystialLubellionSelecting = false;
        bool albionTheShroudedDragonSelecting = false;
        bool nadirActivated = false;
        List<int> infiniteImpermanenceList = new List<int>();
        List<ClientCard> currentNegateMonsterList = new List<ClientCard>();
        List<ClientCard> currentDestroyCardList = new List<ClientCard>();
        List<ClientCard> sendToGYThisTurn = new List<ClientCard>();
        List<int> activatedCardIdList = new List<int>();
        ClientCard fusionTarget = null;
        List<ClientCard> selectedFusionMaterial = new List<ClientCard>();

        /// <summary>
        /// Shuffle List<ClientCard> and return a random-order card list
        /// </summary>
        public List<T> ShuffleList<T>(List<T> list)
        {
            List<T> result = list;
            int n = result.Count;
            while (n-- > 1)
            {
                int index = Program.Rand.Next(result.Count);
                int nextIndex = (index + Program.Rand.Next(result.Count - 1)) % result.Count;
                T tempCard = result[index];
                result[index] = result[nextIndex];
                result[nextIndex] = tempCard;
            }
            return result;
        }

        public bool CheckCanBeTargeted(ClientCard card, bool canBeTarget, CardType selfType)
        {
            if (card == null) return true;
            if (canBeTarget)
            {
                if (card.IsShouldNotBeTarget()) return false;
                if (((int)selfType & (int)CardType.Monster) > 0 && card.IsShouldNotBeMonsterTarget()) return false;
                if (((int)selfType & (int)CardType.Spell) > 0 && card.IsShouldNotBeSpellTrapTarget()) return false;
                if (((int)selfType & (int)CardType.Trap) > 0
                    && (card.IsShouldNotBeSpellTrapTarget() || (!card.IsDisabled()))) return false;
            }
            return true;
        }

        /// <summary>
        /// Check remain cards in deck
        /// </summary>
        /// <param name="id">Card's ID</param>
        public int CheckRemainInDeck(int id)
        {
            for (int count = 1; count < 4; ++count)
            {
                if (DeckCountTable[count].Contains(id)) {
                    return Bot.GetRemainingCount(id, count);
                }
            }
            return 0;
        }

        public int CheckRemainInDeck(params int[] ids)
        {
            int sum = 0;
            foreach (int id in ids)
            {
                sum += CheckRemainInDeck(id);
            }
            return sum;
        }

        /// <summary>
        /// Check whether'll be negated
        /// </summary>
        /// <param name="isCounter">check whether card itself is disabled.</param>
        public bool CheckWhetherNegated(bool disablecheck = true, bool toFieldCheck = false, CardType type = 0)
        {
            bool isMonster = type == 0 && Card.IsMonster();
            isMonster |= ((int)type & (int)CardType.Monster) != 0;
            bool isSpellOrTrap = type == 0 && (Card.IsSpell() || Card.IsTrap());
            isSpellOrTrap |= (((int)type & (int)CardType.Spell) != 0) || (((int)type & (int)CardType.Trap) != 0);
            bool isCounter = ((int)type & (int)CardType.Counter) != 0;
            if (isSpellOrTrap && toFieldCheck && CheckSpellWillBeNegate(isCounter))
                return true;
            if (DefaultCheckWhetherCardIsNegated(Card)) return true;
            if (isMonster && (toFieldCheck || Card.Location == CardLocation.MonsterZone))
            {
                if ((toFieldCheck && (((int)type & (int)CardType.Link) != 0)) || Card.IsDefense())
                {
                    if (Enemy.MonsterZone.Any(card => CheckNumber41(card)) || Bot.MonsterZone.Any(card => CheckNumber41(card))) return true;
                }
                if (Enemy.HasInSpellZone(CardId.SkillDrain, true, true)) return true;
            }
            if (disablecheck) return Card.IsDisabled();
            return false;
        }

        public bool CheckNumber41(ClientCard card)
        {
            return card != null && card.IsFaceup() && card.IsCode(CardId.Number41BagooskatheTerriblyTiredTapir) && card.IsDefense() && !card.IsDisabled();
        }

        /// <summary>
        /// Whether spell or trap will be negate. If so, return true.
        /// </summary>
        /// <param name="isCounter">is counter trap</param>
        /// <param name="target">check target</param>
        /// <returns></returns>
        public bool CheckSpellWillBeNegate(bool isCounter = false, ClientCard target = null)
        {
            // target default set
            if (target == null) target = Card;
            // won't negate if not on field
            if (target.Location != CardLocation.SpellZone && target.Location != CardLocation.Hand) return false;

            // negate judge
            if (Enemy.HasInMonstersZone(CardId.NaturalExterio, true) && !isCounter) return true;
            if (target.IsSpell())
            {
                if (Enemy.HasInMonstersZone(CardId.NaturalBeast, true)) return true;
                if (Enemy.HasInSpellZone(CardId.ImperialOrder, true) || Bot.HasInSpellZone(CardId.ImperialOrder, true)) return true;
                if (Enemy.HasInMonstersZone(CardId.SwordsmanLV7, true) || Bot.HasInMonstersZone(CardId.SwordsmanLV7, true)) return true;
            }
            if (target.IsTrap() && (Enemy.HasInSpellZone(CardId.RoyalDecree, true) || Bot.HasInSpellZone(CardId.RoyalDecree, true))) return true;
            if (target.Location == CardLocation.SpellZone && (target.IsSpell() || target.IsTrap()))
            {
                int selfSeq = -1;
                for (int i = 0; i < 5; ++i)
                {
                    if (Bot.SpellZone[i] == Card) selfSeq = i;
                }
                if (infiniteImpermanenceList.Contains(selfSeq)) return true;
            }
            // how to get here?
            return false;
        }

        /// <summary>
        /// Check whether last chain card should be disabled.
        /// </summary>
        public bool CheckLastChainShouldNegated()
        {
            ClientCard lastcard = Util.GetLastChainCard();
            if (lastcard == null || lastcard.Controller != 1) return false;
            if (lastcard.IsMonster() && lastcard.HasSetcode(SetcodeTimeLord) && Duel.Phase == DuelPhase.Standby) return false;
            if (notToNegateIdList.Contains(lastcard.Id)) return false;
            if (DefaultCheckWhetherCardIsNegated(lastcard)) return false;

            return true;
        }

        /// <summary>
        /// Check whether bot is at advantage.
        /// </summary>
        public bool CheckAtAdvantage()
        {
            if (GetProblematicEnemyMonster() == null && (Duel.Player == 0 || Bot.GetMonsterCount() > 0)) return true;
            return false;
        }

        public bool CheckShouldNoMoreSpSummon()
        {
            if (CheckAtAdvantage() && enemyActivateMaxxC && !enemyActivateLockBird && (Duel.Turn == 1 || Duel.Phase >= DuelPhase.Main2))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check whether cards will be removed. If so, do not send cards to grave.
        /// </summary>
        public bool CheckWhetherWillbeRemoved()
        {
            if (dimensionShifterCount > 0) return true;
            List<int> checkIdList = new List<int> { CardId.BanisheroftheRadiance, CardId.BanisheroftheLight, CardId.MacroCosmos, CardId.DimensionalFissure,
                CardId.KashtiraAriseHeart, 58481572 };
            foreach (int cardid in checkIdList)
            {
                List<ClientField> fields = new List<ClientField> { Bot, Enemy };
                foreach (ClientField cf in fields)
                {
                    if (cf.HasInMonstersZone(cardid, true, false, true) || cf.HasInSpellZone(cardid, true, true))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CheckAnyInGrave(params int[] cardids)
        {
            foreach (int cardid in cardids)
            {
                if (Bot.HasInGraveyard(cardid)) return true;
            }
            return false;
        }

        public ClientCard GetProblematicEnemyMonster(int attack = 0, bool canBeTarget = false, bool ignoreCurrentDestroy = false, CardType selfType = 0)
        {
            List<ClientCard> floodagateList = Enemy.GetMonsters().Where(c => c?.Data != null &&
                c.IsFloodgate() && c.IsFaceup()
                && CheckCanBeTargeted(c, canBeTarget, selfType)
                && (!ignoreCurrentDestroy || !currentDestroyCardList.Contains(c))).OrderByDescending(card => card.Attack).ToList();
            if (floodagateList.Count() > 0) return floodagateList[0];

            List<ClientCard> dangerList = Enemy.MonsterZone.Where(c => c?.Data != null &&
                c.IsMonsterDangerous() && c.IsFaceup() && CheckCanBeTargeted(c, canBeTarget, selfType)
                && (!ignoreCurrentDestroy || !currentDestroyCardList.Contains(c))).OrderByDescending(card => card.Attack).ToList();
            if (dangerList.Count() > 0) return dangerList[0];

            List<ClientCard> invincibleList = Enemy.MonsterZone.Where(c => c?.Data != null &&
                c.IsMonsterInvincible() && c.IsFaceup() && CheckCanBeTargeted(c, canBeTarget, selfType)
                && (!ignoreCurrentDestroy || !currentDestroyCardList.Contains(c))).OrderByDescending(card => card.Attack).ToList();
            if (invincibleList.Count() > 0) return invincibleList[0];

            List<ClientCard> equippedList = Enemy.MonsterZone.Where(c => c?.Data != null &&
                c.EquipCards.Count() > 0 && CheckCanBeTargeted(c, canBeTarget, selfType)
                && (!ignoreCurrentDestroy || !currentDestroyCardList.Contains(c))).OrderByDescending(card => card.Attack).ToList();
            if (equippedList.Count() > 0) return equippedList[0];

            List<ClientCard> enemyMonsters = Enemy.GetMonsters().OrderByDescending(card => card.Attack).ToList();
            if (enemyMonsters.Count() > 0)
            {
                foreach (ClientCard target in enemyMonsters)
                {
                    if ((target.HasType(CardType.Fusion | CardType.Ritual | CardType.Synchro | CardType.Xyz)
                            || (target.HasType(CardType.Link) && target.LinkCount >= 2))
                        && CheckCanBeTargeted(target, canBeTarget, selfType) && (!ignoreCurrentDestroy || !currentDestroyCardList.Contains(target))
                    ) return target;
                }
            }

            if (attack >= 0)
            {
                if (attack == 0)
                    attack = Util.GetBestAttack(Bot);
                List<ClientCard> betterList = Enemy.MonsterZone.GetMonsters()
                    .Where(card => card.GetDefensePower() >= attack && card.GetDefensePower() > 0 && card.IsAttack() && CheckCanBeTargeted(card, canBeTarget, selfType)
                    && (!ignoreCurrentDestroy || !currentDestroyCardList.Contains(card))).OrderByDescending(card => card.Attack).ToList();
                if (betterList.Count() > 0) return betterList[0];
            }
            return null;
        }

        /// <summary>
        /// check enemy's dangerous card in grave
        /// </summary>
        public List<ClientCard> GetDangerousCardinEnemyGrave(bool onlyMonster = false)
        {
            List<ClientCard> result = Enemy.Graveyard.GetMatchingCards(card =>
                (!onlyMonster || card.IsMonster()) && (card.HasSetcode(SetcodeOrcust) || card.HasSetcode(SetcodePhantom) || card.HasSetcode(SetcodeHorus))).ToList();
            List<int> dangerMonsterIdList = new List<int>{
                99937011, 63542003, 9411399, 28954097, 30680659
            };
            result.AddRange(Enemy.Graveyard.GetMatchingCards(card => dangerMonsterIdList.Contains(card.Id)));
            return result;
        }

        public List<ClientCard> GetMonsterListForTargetNegate(bool canBeTarget = false, CardType selfType = 0)
        {
            List<ClientCard> resultList = new List<ClientCard>();
            if (CheckWhetherNegated())
            {
                return resultList;
            }

            // negate before used
            ClientCard target = Enemy.MonsterZone.FirstOrDefault(card => card?.Data != null
                    && card.IsMonsterShouldBeDisabledBeforeItUseEffect() && card.IsFaceup() && !card.IsShouldNotBeTarget()
                    && CheckCanBeTargeted(card, canBeTarget, selfType)
                    && !currentNegateMonsterList.Contains(card));
            if (target != null)
            {
                resultList.Add(target);
            }

            // negate monster effect on the field
            foreach (ClientCard chainingCard in Duel.CurrentChain)
            {
                if (chainingCard.Location == CardLocation.MonsterZone && chainingCard.Controller == 1 && !chainingCard.IsDisabled()
                && CheckCanBeTargeted(chainingCard, canBeTarget, selfType) && !currentNegateMonsterList.Contains(chainingCard))
                {
                    resultList.Add(chainingCard);
                }
            }

            return resultList;
        }

        /// <summary>
        /// go first
        /// </summary>
        public override bool OnSelectHand()
        {
            return true;
        }

        public override IList<ClientCard> OnSelectCard(IList<ClientCard> cards, int min, int max, int hint, bool cancelable)
        {
            ClientCard currentSolvingChain = Duel.GetCurrentSolvingChainCard();
            if (currentSolvingChain != null)
            {
                // search operation
                if (hint == HintMsg.AddToHand)
                {
                    Dictionary<int, Func<bool>> checkDict = new Dictionary<int, Func<bool>>();

                    // for Aluber or Kitt
                    if (currentSolvingChain.IsCode(CardId.AluberTheJesterOfDespia) || currentSolvingChain.IsCode(CardId.SpringansKitt))
                    {
                        checkDict = new Dictionary<int, Func<bool>>{
                            {CardId.BrandedFusion, () => BrandedFusionActivateCheck()},
                            {CardId.BrandedLost, () => {
                                if (Duel.Player == 0 && Duel.Phase >= DuelPhase.End) return false;
                                if (Bot.HasInHandOrInSpellZone(CardId.BrandedFusion) && BrandedFusionActivateCheck()) return true;
                                if (Bot.HasInHandOrInSpellZone(CardId.BrandedInWhite) && BrandedInWhiteActivateCheck()) return true;
                                if (Bot.HasInHandOrInSpellZone(CardId.BrandedInRed) && BrandedInRedActivateCheck() != null) return true;
                                if (!summoned && Bot.HasInHand(CardId.FallenOfAlbaz) && CheckAlbazFusion()) return true;
                                if ((Bot.HasInMonstersZone(CardId.BlazingCartesiaTheVirtuous) || (!summoned && Bot.HasInHand(CardId.BlazingCartesiaTheVirtuous)))) return true;
                                return false;
                            }
                            },
                            {CardId.BrandedInHighSpirits, BrandedInHighSpiritsActivateCheck},
                            {CardId.BrandedInRed, () => BrandedInRedActivateCheck() != null },
                            {CardId.BrandedInWhite, BrandedInWhiteActivateCheck },
                            {CardId.BrandedRetribution, () => cards.Any(c => c.IsCode(CardId.BrandedRetribution) && c.Location == CardLocation.Removed) },
                            {CardId.BrightestBlazingBrandedKing, () => Bot.GetMonsters().Any(c => c.IsFaceup() && albazFusionMonster.Contains(c.Id)) },
                            {CardId.BrandedOpening, () => Bot.Hand.Count() > 2 }
                        };
                    }

                    // for Lenatus
                    if (currentSolvingChain.IsCode(CardId.AlbaLenatusTheAbyssDragon))
                    {
                        checkDict = new Dictionary<int, Func<bool>>{
                            {CardId.BrandedFusion, () => BrandedFusionActivateCheck(false)},
                            {CardId.FusionDeployment, () => true}
                        };
                    }
                    
                    // for lost / mercourier
                    if (currentSolvingChain.IsCode(CardId.BrandedLost) || currentSolvingChain.IsCode(CardId.TriBrigadeMercourier))
                    {
                        bool canSummon = Duel.Player == 0 && Duel.Phase < DuelPhase.End && !summoned;
                        checkDict = new Dictionary<int, Func<bool>>{
                            {CardId.TriBrigadeMercourier, () => Bot.GetMonsters().Any(c => c.IsFaceup() && albazFusionMonster.Contains(c.Id)) },
                            {CardId.GuidingQuemTheVirtuous, () => canSummon },
                            {CardId.BlazingCartesiaTheVirtuous, () => canSummon || (!CheckShouldNoMoreSpSummon() && Bot.HasInMonstersZoneOrInGraveyard(CardId.FallenOfAlbaz))},
                            {CardId.AlbionTheShroudedDragon, () => !CheckWhetherWillbeRemoved() && !activatedCardIdList.Contains(CardId.AlbionTheShroudedDragon) },
                            {CardId.FallenOfAlbaz, () => canSummon && CheckAlbazFusion() },
                            {CardId.SpringansKitt, () => true }
                        };
                    }

                    foreach (KeyValuePair<int, Func<bool>> pair in checkDict)
                    {
                        ClientCard target = cards.FirstOrDefault(card => card.IsCode(pair.Key));
                        if (target != null && pair.Value())
                        {
                            return Util.CheckSelectCount(new List<ClientCard> { target }, cards, min, max);
                        }
                    }
                }

                // search for opening
                if (hint == HintMsg.OperateCard && currentSolvingChain.IsCode(CardId.BrandedOpening))
                {
                    Dictionary<int, Func<bool>> checkDict = new Dictionary<int, Func<bool>>{
                        {CardId.AluberTheJesterOfDespia, () => !activatedCardIdList.Contains(CardId.AluberTheJesterOfDespia)},
                        {CardId.GuidingQuemTheVirtuous, () => true },
                        {CardId.DespianTragedy, () => true }
                    };
                    foreach (KeyValuePair<int, Func<bool>> pair in checkDict)
                    {
                        ClientCard target = cards.FirstOrDefault(card => card.IsCode(pair.Key));
                        if (target != null && pair.Value())
                        {
                            return Util.CheckSelectCount(new List<ClientCard> { target }, cards, min, max);
                        }
                    }
                }

                // spsummon for deployment
                if (currentSolvingChain.IsCode(CardId.FusionDeployment))
                {
                    int summonId = FusionDeploymentSpSummonTarget();
                    if (summonId > 0)
                    {
                        if (hint == HintMsg.Confirm)
                        {
                            if (summonId == CardId.BlazingCartesiaTheVirtuous)
                            {
                                ClientCard target = cards.FirstOrDefault(card => card.IsCode(CardId.GranguignolTheDuskDragon));
                                if (target != null)
                                {
                                    return Util.CheckSelectCount(new List<ClientCard> { target }, cards, min, max);
                                }
                            }
                            else if (summonId == CardId.FallenOfAlbaz)
                            {
                                List<ClientCard> shuffleList = ShuffleList(new List<ClientCard>(cards));
                                foreach (ClientCard target in shuffleList)
                                {
                                    if (albazFusionMonster.Contains(target.Id))
                                    {
                                        return Util.CheckSelectCount(new List<ClientCard> { target }, cards, min, max);
                                    }
                                }
                            }
                        }
                        if (hint == HintMsg.SpSummon)
                        {
                            foreach (ClientCard target in cards)
                            {
                                if (target.IsCode(summonId))
                                {
                                    return Util.CheckSelectCount(new List<ClientCard> { target }, cards, min, max);
                                }
                            }
                        }
                    }
                }

                // for lubellion
                if (currentSolvingChain.IsCode(CardId.TheBystialLubellion))
                {
                    List<int> checkIdList = new List<int>();
                    if (hint == HintMsg.ToField)
                    {
                        checkIdList.AddRange(new[] { CardId.BrandedLost, CardId.BrandedBeast } );
                    } else if (hint == HintMsg.AddToHand)
                    {
                        checkIdList.Add(CardId.BystialSaronir);
                    }
                    foreach (int checkId in checkIdList)
                    {
                        ClientCard target = cards.FirstOrDefault(c => c.Id == checkId);
                        if (target != null)
                        {
                            SelectSTPlace(target, false);
                            return Util.CheckSelectCount(new List<ClientCard> { target }, cards, min, max);
                        }
                    }
                }
            }

            // drop 1 hand
            bool discardHand = hint == HintMsg.Discard;
            bool handToDeck = hint == HintMsg.ToDeck && cards.All(c => c.Location == CardLocation.Hand);
            if (min == 1 && max == 1 && (discardHand || handToDeck))
            {
                if (currentSolvingChain != null && currentSolvingChain.IsCode(CardId.BrandedOpening))
                {
                    ClientCard tragedy = cards.FirstOrDefault(card => card.IsCode(CardId.DespianTragedy));
                    if (tragedy != null)
                    {
                        return Util.CheckSelectCount(new List<ClientCard> { tragedy }, cards, min, max);
                    }
                }
                if (discardHand)
                {
                    // discard activating shrouded
                    foreach (ClientCard target in cards)
                    {
                        if (target.IsCode(CardId.AlbionTheShroudedDragon) && Duel.CurrentChain.Contains(target))
                        {
                            return Util.CheckSelectCount(new List<ClientCard> { target }, cards, min, max);
                        }
                    }

                    List<int> discardList = new List<int> { CardId.BrandedRetribution, CardId.AlbionTheShroudedDragon, CardId.BrightestBlazingBrandedKing, CardId.BrandedInHighSpirits, CardId.BlazingCartesiaTheVirtuous };
                    foreach (int id in discardList)
                    {
                        ClientCard card = cards.FirstOrDefault(c => c.IsCode(id));
                        if (card != null)
                        {
                            return Util.CheckSelectCount(new List<ClientCard> { card }, cards, min, max);
                        }
                    }
                }
                // TODO
            }

            // for The Bystial Lubellion
            if (theBystialLubellionSelecting)
            {
                theBystialLubellionSelecting = false;
                ClientCard target = TheBystialLubellionSpSummonCost(cards);
                if (target != null)
                {
                    return Util.CheckSelectCount(new List<ClientCard> { target }, cards, min, max);
                } else
                {
                    List<ClientCard> targetList = new List<ClientCard>(cards);
                    targetList.Sort(CardContainer.CompareCardAttack);
                    return Util.CheckSelectCount(targetList, cards, min, max);
                }
            }

            // for shrouded/saronir
            if (albionTheShroudedDragonSelecting || (currentSolvingChain != null && currentSolvingChain.IsCode(CardId.BystialSaronir)))
            {
                // send retribution first
                ClientCard retribution = cards.FirstOrDefault(c => c.IsCode(CardId.BrandedRetribution));
                if (retribution != null)
                {
                    if (retribution.Location == CardLocation.Deck || Bot.GetGraveyardMonsters().Where(c => albazFusionMonster.Contains(c.Id)).Count() < 2)
                    {
                        return Util.CheckSelectCount(new List<ClientCard> { retribution }, cards, min, max);
                    }
                }
                // send spells to recycle
                if (Bot.HasInGraveyard(CardId.BrandedRetribution) || (Bot.HasInGraveyard(CardId.DespianTragedy) && !activatedCardIdList.Contains(CardId.DespianTragedy)))
                {
                    Dictionary<int, Func<bool>> deckCheckDict = new Dictionary<int, Func<bool>>{
                            {CardId.BrandedFusion, () => BrandedFusionActivateCheck()},
                                {CardId.BrandedLost, () => {
                                    if (Duel.Player == 0 && Duel.Phase >= DuelPhase.End) return false;
                                    if (Bot.HasInHandOrInSpellZone(CardId.BrandedFusion) && BrandedFusionActivateCheck()) return true;
                                    if (Bot.HasInHandOrInSpellZone(CardId.BrandedInWhite) && BrandedInWhiteActivateCheck()) return true;
                                    if (Bot.HasInHandOrInSpellZone(CardId.BrandedInRed) && BrandedInRedActivateCheck() != null) return true;
                                    if (!summoned && Bot.HasInHand(CardId.FallenOfAlbaz) && CheckAlbazFusion()) return true;
                                    if ((Bot.HasInMonstersZone(CardId.BlazingCartesiaTheVirtuous) || (!summoned && Bot.HasInHand(CardId.BlazingCartesiaTheVirtuous)))) return true;
                                    return false;
                                }
                            },
                            {CardId.BrandedInHighSpirits, BrandedInHighSpiritsActivateCheck},
                            {CardId.BrandedInRed, () => BrandedInRedActivateCheck() != null },
                            {CardId.BrandedInWhite, BrandedInWhiteActivateCheck },
                            {CardId.BrandedRetribution, () => cards.Any(c => c.IsCode(CardId.BrandedRetribution) && c.Location == CardLocation.Removed) },
                            {CardId.BrightestBlazingBrandedKing, () => Bot.GetMonsters().Any(c => c.IsFaceup() && albazFusionMonster.Contains(c.Id)) },
                            {CardId.BrandedOpening, () => Bot.Hand.Count() > 2 }
                        };
                    foreach (KeyValuePair<int, Func<bool>> pair in deckCheckDict)
                    {
                        ClientCard target = cards.FirstOrDefault(card => card.Location == CardLocation.Deck && card.IsCode(pair.Key));
                        if (target != null && pair.Value())
                        {
                            return Util.CheckSelectCount(new List<ClientCard> { target }, cards, min, max);
                        }
                    }
                }

                // for abyss dragon
                if (currentSolvingChain.IsCode(CardId.AlbionTheShroudedDragon) &&
                    FallenOfAlbazSetCheck() && (summoned || !Bot.HasInHand(new List<int> { CardId.FallenOfAlbaz, CardId.BrandedInHighSpirits })))
                {
                    List<int> checkIdList = new List<int> {
                            CardId.BrandedRetribution, CardId.BrandedInHighSpirits, CardId.BrightestBlazingBrandedKing, CardId.BrandedInWhite, CardId.BrandedOpening,
                            CardId.BrandedInRed, CardId.BrandedBeast, CardId.BrandedLost
                        };
                    if (!BrandedFusionActivateCheck())
                    {
                        checkIdList.Add(CardId.BrandedFusion);
                    }
                    foreach (int checkId in checkIdList)
                    {
                        ClientCard target = cards.FirstOrDefault(c => c.Id == checkId);
                        if (target != null)
                        {
                            return Util.CheckSelectCount(new List<ClientCard> { target }, cards, min, max);
                        }
                    }
                }

                // send from deck
                List<int> checkList = new List<int> { CardId.BrandedInHighSpirits, CardId.BrandedOpening, CardId.BrightestBlazingBrandedKing, CardId.BrandedBeast, CardId.BrandedLost };
                foreach (int checkId in checkList)
                {
                    ClientCard target = cards.FirstOrDefault(c => c.IsCode(checkId) && c.Location == CardLocation.Deck);
                    if (target != null)
                    {
                        return Util.CheckSelectCount(new List<ClientCard> { target }, cards, min, max);
                    }
                }
                return Util.CheckSelectCount(ShuffleList(new List<ClientCard>(cards)), cards, min, max);
            }

            return base.OnSelectCard(cards, min, max, hint, cancelable);
        }

        public override int OnSelectOption(IList<int> options)
        {
            ClientCard currentSolvingChain = Duel.GetCurrentSolvingChainCard();
            if (currentSolvingChain != null)
            {
                if (currentSolvingChain.IsCode(CardId.BrandedOpening) && options.Count() == 2 && options.Contains(1190) && options.Contains(1152))
                {
                    // 1190=Add to Hand, 1152=Special Summon
                    if (CheckShouldNoMoreSpSummon() && !summoned)
                    {
                        return options.IndexOf(1190);
                    } else
                    {
                        return options.IndexOf(1152);
                    }
                }
            }

            return base.OnSelectOption(options);
        }

        public override int OnSelectPlace(int cardId, int player, CardLocation location, int available)
        {
            if (player == 0 && location == CardLocation.MonsterZone)
            {
                List<int> zoneIdList = ShuffleList(new List<int> { 5, 6 });
                zoneIdList.AddRange(ShuffleList(new List<int> { 0, 2, 4 }));
                zoneIdList.AddRange(ShuffleList(new List<int> { 1, 3 }));
                foreach (int zoneId in zoneIdList)
                {
                    int zone = (int)System.Math.Pow(2, zoneId);
                    if ((available & zone) != 0 && Bot.MonsterZone[zoneId] == null)
                    {
                        return zone;
                    }
                }
            }
            return base.OnSelectPlace(cardId, player, location, available);
        }

        public override CardPosition OnSelectPosition(int cardId, IList<CardPosition> positions)
        {
            YGOSharp.OCGWrapper.NamedCard cardData = YGOSharp.OCGWrapper.NamedCard.Get(cardId);
            if (cardData != null)
            {
                if (Duel.Turn == 1 || Duel.Phase >= DuelPhase.Main2)
                {
                    bool turnDefense = false;
                    if (cardData.Attack <= cardData.Defense)
                    {
                        turnDefense = true;
                    }
                    if (turnDefense)
                    {
                        return CardPosition.FaceUpDefence;
                    }
                }
                if (Duel.Player == 1)
                {
                    if (cardData.Defense >= cardData.Attack || Util.IsOneEnemyBetterThanValue(cardData.Attack, true))
                    {
                        return CardPosition.FaceUpDefence;
                    }
                }
                int cardAttack = cardData.Attack;
                int bestBotAttack = Math.Max(Util.GetBestAttack(Bot), cardAttack);
                if (Util.IsAllEnemyBetterThanValue(bestBotAttack, true))
                {
                    return CardPosition.FaceUpDefence;
                }
            }
            return base.OnSelectPosition(cardId, positions);
        }

        public override void OnNewTurn()
        {
            if (Duel.Turn <= 1)
            {
                dimensionShifterCount = 0;
            }

            summoned = false;
            enemyActivateMaxxC = false;
            enemyActivateLockBird = false;
            enemyActivateInfiniteImpermanenceFromHand = false;
            nadirActivated = false;
            if (dimensionShifterCount > 0) dimensionShifterCount--;
            infiniteImpermanenceList.Clear();
            currentNegateMonsterList.Clear();
            currentDestroyCardList.Clear();
            sendToGYThisTurn.Clear();
            activatedCardIdList.Clear();
            base.OnNewTurn();
        }

        public override void OnChaining(int player, ClientCard card)
        {
            if (card == null) return;
            
            if (player == 1)
            {
                if (card.IsCode(_CardId.InfiniteImpermanence))
                {
                    if (enemyActivateInfiniteImpermanenceFromHand)
                    {
                        enemyActivateInfiniteImpermanenceFromHand = false;
                    }
                    else
                    {
                        for (int i = 0; i < 5; ++i)
                        {
                            if (Enemy.SpellZone[i] == card)
                            {
                                infiniteImpermanenceList.Add(4 - i);
                                break;
                            }
                        }
                    }
                }
            }
            base.OnChaining(player, card);
        }

        public override void OnChainSolved(int chainIndex)
        {
            ClientCard currentCard = Duel.GetCurrentSolvingChainCard();
            if (currentCard != null && !Duel.IsCurrentSolvingChainNegated())
            {
                if (currentCard.Controller == 1)
                {
                    if (currentCard.IsCode(_CardId.MaxxC))
                        enemyActivateMaxxC = true;
                    if (currentCard.IsCode(_CardId.LockBird))
                        enemyActivateLockBird = true;
                    if (currentCard.IsCode(CardId.DimensionShifter))
                        dimensionShifterCount = 2;
                }
                if (currentCard.Controller == 0 && currentCard.IsCode(CardId.NadirServant))
                {
                    nadirActivated = true;
                }
            }
            fusionTarget = null;
            selectedFusionMaterial.Clear();

            base.OnChainSolved(chainIndex);
        }

        public override void OnChainEnd()
        {
            currentNegateMonsterList.Clear();
            currentDestroyCardList.Clear();
            enemyActivateInfiniteImpermanenceFromHand = false;
            theBystialLubellionSelecting = false;
            albionTheShroudedDragonSelecting = false;
            base.OnChainEnd();
        }

        public override void OnMove(ClientCard card, int previousControler, int previousLocation, int currentControler, int currentLocation)
        {
            if (previousControler == 1)
            {
                if (card != null)
                {
                    if (card.IsCode(_CardId.InfiniteImpermanence) && previousLocation == (int)CardLocation.Hand && currentLocation == (int)CardLocation.SpellZone)
                        enemyActivateInfiniteImpermanenceFromHand = true;
                }
            }
            if (card != null)
            {
                if (currentControler == 0)
                {
                    ClientCard currentSolvingChain = Duel.GetCurrentSolvingChainCard();
                    if (previousLocation == (int)CardLocation.Grave && currentLocation != (int)CardLocation.Grave)
                    {
                        sendToGYThisTurn.Remove(card);
                    }
                    if (currentLocation == (int)CardLocation.Grave)
                    {
                        sendToGYThisTurn.Add(card);
                    }
                }
            }

            base.OnMove(card, previousControler, previousLocation, currentControler, currentLocation);
        }

        /// <summary>
        /// Select spell/trap's place randomly to avoid InfiniteImpermanence and so on.
        /// </summary>
        /// <param name="card">Card to set(default current card)</param>
        /// <param name="avoidImpermanence">Whether need to avoid InfiniteImpermanence</param>
        /// <param name="avoidList">Whether need to avoid set in this place</param>
        public void SelectSTPlace(ClientCard card = null, bool avoidImpermanence = false, List<int> avoidList = null)
        {
            if (card == null) card = Card;
            List<int> list = new List<int>();
            for (int seq = 0; seq < 5; ++seq)
            {
                if (Bot.SpellZone[seq] == null)
                {
                    if (card != null && card.Location == CardLocation.Hand && avoidImpermanence && infiniteImpermanenceList.Contains(seq)) continue;
                    if (avoidList != null && avoidList.Contains(seq)) continue;
                    list.Add(seq);
                }
            }
            int n = list.Count;
            while (n-- > 1)
            {
                int index = Program.Rand.Next(list.Count);
                int nextIndex = (index + Program.Rand.Next(list.Count - 1)) % list.Count;
                int tempInt = list[index];
                list[index] = list[nextIndex];
                list[nextIndex] = tempInt;
            }
            if (avoidImpermanence && Bot.GetMonsters().Any(c => c.IsFaceup() && !c.IsDisabled()))
            {
                foreach (int seq in list)
                {
                    ClientCard enemySpell = Enemy.SpellZone[4 - seq];
                    if (enemySpell != null && enemySpell.IsFacedown()) continue;
                    int zone = (int)System.Math.Pow(2, seq);
                    AI.SelectPlace(zone);
                    return;
                }
            }
            foreach (int seq in list)
            {
                int zone = (int)System.Math.Pow(2, seq);
                AI.SelectPlace(zone);
                return;
            }
            AI.SelectPlace(0);
        }

        public bool TheBystialLubellionSpSummon()
        {
            if (Card.Location == CardLocation.Hand)
            {
                return false;
            }
            ClientCard costTarget = TheBystialLubellionSpSummonCost(Bot.GetMonsters());
            if (costTarget != null)
            {
                theBystialLubellionSelecting = true;
                return true;
            }
            return false;
        }

        public ClientCard TheBystialLubellionSpSummonCost(IList<ClientCard> costList)
        {
            Dictionary<int, Func<ClientCard, bool>> checkDict = new Dictionary<int, Func<ClientCard, bool>>{
                {CardId.AlbionTheBrandedDragon, (card) => sendToGYThisTurn.All(c => !c.IsCode(CardId.AlbionTheBrandedDragon))},
                {CardId.BystialSaronir, (card) => !activatedCardIdList.Contains(CardId.BystialSaronir + 1) && !CheckWhetherWillbeRemoved() },
                {CardId.TitanikladTheAshDragon, (card) => Util.IsTurn1OrMain2() || card.GetDefensePower() < 2500 },
                {CardId.AlbaLenatusTheAbyssDragon, (card) => Util.IsTurn1OrMain2() || card.IsDisabled() || card.GetDefensePower() < 2500 },
                {CardId.AlbionTheShroudedDragon, (card) => Util.IsTurn1OrMain2() || card.GetDefensePower() < 2500 },
                {CardId.BorreloadFuriousDragon, (card) => card.IsDisabled() && CheckRemainInDeck(CardId.BrandedBeast, CardId.BrandedLost) > 0 },
            };

            foreach (KeyValuePair<int, Func<ClientCard, bool>> pair in checkDict)
            {
                List<ClientCard> targetList = costList.Where(card => card.IsCode(pair.Key)).ToList();
                foreach (ClientCard target in targetList)
                {
                    if (target != null && pair.Value(target))
                    {
                        return target;
                    }
                }
            }
            return null;
        }

        public bool TheBystialLubellionActivate()
        {
            if (CheckWhetherNegated(true, Card.Location == CardLocation.MonsterZone, CardType.Monster)) return false;
            if (Card.Location == CardLocation.Hand)
            {
                activatedCardIdList.Add(Card.Id);
            } else
            {
                activatedCardIdList.Add(Card.Id + 1);
            }
            return true;
        }

        public bool AlbionTheShroudedDragonActivate()
        {
            if (CheckWhetherNegated(true, false, CardType.Monster) || CheckWhetherWillbeRemoved()) return false;
            bool checkFlag = CheckRemainInDeck(CardId.BrandedRetribution, CardId.BrandedOpening, CardId.BrightestBlazingBrandedKing, CardId.BrandedInHighSpirits) > 0;
            if (Bot.HasInGraveyard(CardId.BrandedRetribution))
            {
                checkFlag |= CheckRemainInDeck(CardId.BrandedFusion, CardId.BrandedBeast, CardId.BrandedInRed, CardId.BrandedInWhite, CardId.BrandedLost) > 0;
            }
            if (Bot.HasInSpellZone(CardId.BrandedBeast))
            {
                checkFlag |= CheckRemainInDeck(CardId.BrandedLost) > 0;
            }
            if (Card.Location == CardLocation.Grave)
            {
                checkFlag |= CheckRemainInDeck(CardId.BrandedInWhite) > 0;
            }
            // for abyss dragon
            if (FallenOfAlbazSetCheck() && (summoned || !Bot.HasInHand(new List<int> { CardId.FallenOfAlbaz, CardId.BrandedInHighSpirits })))
            {
                checkFlag |= Bot.HasInHand(new List<int> { CardId.BrandedBeast, CardId.BrandedInHighSpirits, CardId.BrandedInWhite, CardId.BrandedInRed, CardId.BrandedLost, CardId.BrandedOpening, CardId.BrandedRetribution, CardId.BrightestBlazingBrandedKing });
            }

            if (checkFlag)
            {
                activatedCardIdList.Add(Card.Id);
                albionTheShroudedDragonSelecting = true;
                return true;
            }
            return false;
        }

        public bool BystialSaronirActivate()
        {
            if (CheckWhetherNegated(true, false, CardType.Monster)) return false;
            // banish & spsummon
            if (Card.Location == CardLocation.Hand)
            {
                // banish enemy card
                ClientCard lastChainedCard = Util.GetLastChainCard();
                if (lastChainedCard != null && lastChainedCard.Controller == 1)
                {
                    if (CheckBystialSaronirCanTarget(lastChainedCard) || Duel.ChainTargets.Any(c => CheckBystialSaronirCanTarget(c)))
                    {
                        AI.SelectCard(lastChainedCard);
                        activatedCardIdList.Add(Card.Id);
                        return true;
                    }
                }
                // banish cards with effect
                if (!CheckShouldNoMoreSpSummon())
                {
                    if (Bot.HasInGraveyard(CardId.TriBrigadeMercourier) && !activatedCardIdList.Contains(CardId.TriBrigadeMercourier + 1))
                    {
                        AI.SelectCard(CardId.TriBrigadeMercourier);
                        activatedCardIdList.Add(Card.Id);
                        return true;
                    }
                    if (Bot.HasInGraveyard(CardId.DespianTragedy) && !activatedCardIdList.Contains(CardId.DespianTragedy))
                    {
                        AI.SelectCard(CardId.DespianTragedy);
                        activatedCardIdList.Add(Card.Id);
                        return true;
                    }
                }
            }
            // send to GY
            if (Card.Location == CardLocation.Grave && !CheckWhetherWillbeRemoved())
            {
                if (Bot.HasInGraveyard(CardId.BrandedRetribution))
                {
                    activatedCardIdList.Add(Card.Id + 1);
                    return true;
                } else if (CheckRemainInDeck(CardId.TheBystialLubellion, CardId.BrandedRetribution, CardId.BrandedInHighSpirits, CardId.BrightestBlazingBrandedKing, CardId.BrandedOpening) > 0)
                {
                    activatedCardIdList.Add(Card.Id + 1);
                    return true;
                }
            }
            return false;
        }

        public bool CheckBystialSaronirCanTarget(ClientCard c)
        {
            return c.Location == CardLocation.Grave && c.HasAttribute(CardAttribute.Light | CardAttribute.Dark);
        }

        public bool AluberTheJesterOfDespiaSummon()
        {
            if (CheckWhetherNegated(true, true, CardType.Monster) || enemyActivateLockBird || activatedCardIdList.Contains(Card.Id)) return false;
            summoned = true;
            return true;
        }

        public bool AluberTheJesterOfDespiaActivate()
        {
            // search
            if (Card.Location == CardLocation.MonsterZone)
            {
                if (CheckWhetherNegated(true, true, CardType.Monster)) return false;
                activatedCardIdList.Add(Card.Id);
                return true;
            }
            // spsummon
            else
            {
                List<ClientCard> targetCardList = GetMonsterListForTargetNegate(true, CardType.Monster);
                ClientCard lastChainCard = Util.GetLastChainCard();
                // chain to protect
                if (lastChainCard != null && lastChainCard.Controller == 0)
                {
                    AI.SelectCard(targetCardList);
                    activatedCardIdList.Add(Card.Id);
                    return true;
                }
                if (CheckWhetherNegated(true, false, CardType.Monster)) return false;
                AI.SelectCard(targetCardList);
                activatedCardIdList.Add(Card.Id);
                return true;
            }
            return false;
        }

        public bool FallenOfAlbazSummon()
        {
            if (CheckAlbazFusion(Card))
            {
                summoned = true;
                return true;
            }
            return false;
        }

        public bool FallenOfAlbazSet()
        {
            if (FallenOfAlbazSetCheck())
            {
                summoned = true;
                return true;
            }
            return false;
        }

        public bool FallenOfAlbazSetCheck()
        {
            if (!Bot.HasInExtra(CardId.AlbaLenatusTheAbyssDragon) || nadirActivated) return false;
            // check dangerous dragon
            if (!Bot.HasInSpellZone(CardId.BrandedLost, true, true) || Bot.GetHandCount() < 2)
            {
                foreach (int dangerId in dangerousDragonIdList)
                {
                    if (Enemy.HasInMonstersZone(dangerId, true, false, true))
                    {
                        return true;
                    }
                }
            }
            // check dragon count
            int dragonCount = Enemy.GetMonsters().Where(c => c != null && c.IsFaceup() && !cannotBeFusionMaterialIdList.Contains(c.Id) && c.HasRace(CardRace.Dragon)).Count();
            if (dragonCount > 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check whether should call albaz.
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public bool CheckAlbazFusion(ClientCard exceptCost = null)
        {
            int costHandCount = Bot.Hand.Where(c => c != exceptCost).Count();
            if (costHandCount <= 0) return false;
            if (CheckWhetherNegated(true, true, CardType.Monster) || activatedCardIdList.Contains(CardId.FallenOfAlbaz) || nadirActivated) return false;
            if (!Bot.HasInMonstersZone(CardId.MirrorjadeTheIcebladeDragon, faceUp: true) && !Bot.HasInSpellZone(CardId.MirrorjadeTheIcebladeDragon)
                && Bot.HasInExtra(CardId.MirrorjadeTheIcebladeDragon))
            {
                if (Enemy.GetMonsters().Any(c => c.IsFaceup() && !cannotBeFusionMaterialIdList.Contains(c.Id) && c.HasType(CardType.Fusion | CardType.Synchro | CardType.Xyz | CardType.Link)))
                {
                    return true;
                }
            }
            if (Bot.HasInExtra(CardId.AlbaLenatusTheAbyssDragon))
            {
                if (Enemy.GetMonsters().Any(c => c.IsFaceup() && !cannotBeFusionMaterialIdList.Contains(c.Id) && c.HasRace(CardRace.Dragon)))
                {
                    return true;
                }
            }
            if (Bot.HasInExtra(CardId.AlbionTheBrandedDragon))
            {
                if (Enemy.GetMonsters().Any(c => c.IsFaceup() && !cannotBeFusionMaterialIdList.Contains(c.Id) && c.HasAttribute(CardAttribute.Light)))
                {
                    return true;
                }
            }
            if (Bot.HasInExtra(CardId.AlbionTheSanctifireDragon))
            {
                if (Enemy.GetMonsters().Any(c => c.IsFaceup() && !cannotBeFusionMaterialIdList.Contains(c.Id) && c.HasAttribute(CardAttribute.Light) && c.HasRace(CardRace.SpellCaster)))
                {
                    return true;
                }
            }
            if (Bot.HasInExtra(CardId.LubellionTheSearingDragon))
            {
                if (costHandCount >= 2 && Enemy.GetMonsters().Any(c => c.IsFaceup() && !cannotBeFusionMaterialIdList.Contains(c.Id) && c.HasAttribute(CardAttribute.Dark)))
                {
                    return true;
                }
            }
            if (Bot.HasInExtra(CardId.TitanikladTheAshDragon))
            {
                if (Enemy.GetMonsters().Any(c => c.IsFaceup() && !cannotBeFusionMaterialIdList.Contains(c.Id) && c.Attack >= 2500))
                {
                    return true;
                }
            }
            if (Bot.HasInExtra(CardId.RindbrummTheStrikingDragon))
            {
                if (Enemy.GetMonsters().Any(c => c.IsFaceup() && !cannotBeFusionMaterialIdList.Contains(c.Id) && c.HasRace(CardRace.Beast | CardRace.BeastWarrior | CardRace.WindBeast)))
                {
                    return true;
                }
            }

            return false;
        }

        public bool FallenOfAlbazActivate()
        {
            if (CheckAlbazFusion())
            {
                return true;
            }
            return false;
        }

        public bool SpringansKittSummon()
        {
            // TODO
            return false;
        }

        public bool SpringansKittActivate()
        {
            // spsummon
            if (Card.Location == CardLocation.Hand)
            {
                if (!CheckWhetherNegated(true, true, CardType.Monster)) return false;
                if (CheckShouldNoMoreSpSummon() && !summoned)
                {
                    return false;
                }
                activatedCardIdList.Add(Card.Id);
                return true;
            }
            // search
            if (Card.Location == CardLocation.MonsterZone)
            {
                if (!CheckWhetherNegated(true, true, CardType.Monster)) return false;
                activatedCardIdList.Add(Card.Id + 1);
                return true;
            }

            return false;
        }

        public bool GuidingQuemTheVirtuousSummon()
        {
            // TODO
            return false;
        }

        public bool GuidingQuemTheVirtuousSummonForSearch()
        {
            if (CheckWhetherNegated(true, true, CardType.Monster) || CheckWhetherWillbeRemoved()) return false;
            if (activatedCardIdList.Contains(Card.Id)) return false;
            if (Bot.HasInGraveyard(CardId.BrandedRetribution) && CheckRemainInDeck(CardId.BrandedFusion, CardId.BrandedLost, CardId.BrandedInWhite, CardId.BrandedInRed) > 0)
            {
                summoned = true;
                return true;
            }
            if (CheckAnyInGrave(CardId.BrandedFusion, CardId.BrandedLost, CardId.BrandedBeast) && CheckRemainInDeck(CardId.BrandedRetribution) > 0)
            {
                summoned = true;
                return true;
            }
            return false;
        }

        public bool GuidingQuemTheVirtuousActivate()
        {
            // TODO
            return false;
        }

        public bool BlazingCartesiaTheVirtuousSummon()
        {
            // TODO
            return false;
        }

        public bool BlazingCartesiaTheVirtuousActivate()
        {
            // TODO
            // sp summon
            if (Card.Location == CardLocation.Hand)
            {
                if (CheckShouldNoMoreSpSummon() || CheckWhetherNegated(true, true, CardType.Monster)) return false;
                activatedCardIdList.Add(Card.Id);
                return true;
            }
            // fusion
            if (Card.Location == CardLocation.MonsterZone)
            {
                // activatedCardIdList.Add(Card.Id + 1);
            }
            // recycle
            if (Card.Location == CardLocation.Grave)
            {
                if (CheckWhetherNegated(true, false, CardType.Monster)) return false;
                activatedCardIdList.Add(Card.Id + 2);
                return true;
            }
            return false;
        }

        public bool TriBrigadeMercourierActivate()
        {
            // TODO
            return false;
        }

        public bool AshBlossomActivate()
        {
            if (CheckWhetherNegated() || !CheckLastChainShouldNegated()) return false;
            if (Util.GetLastChainCard().IsCode(_CardId.MaxxC)) return false;
            if (DefaultAshBlossomAndJoyousSpring())
            {
                if (Util.GetLastChainCard().Location == CardLocation.MonsterZone) currentNegateMonsterList.Add(Util.GetLastChainCard());
                return true;
            }
            return false;
        }

        public bool MaxxCActivate()
        {
            if (CheckWhetherNegated(true) || Duel.LastChainPlayer == 0) return false;
            return DefaultMaxxC();
        }

        public bool DespianTragedyActivate()
        {
            // search
            if (ActivateDescription != Util.GetStringId(Card.Id, 1))
            {
                if (CheckWhetherNegated(true, false, CardType.Monster)) return false;
                activatedCardIdList.Add(Card.Id);
                return true;
            }
            // set
            else {

            }
            // TODO
            return false;
        }

        public bool NadirServantActivate()
        {
            // TODO
            return false;
        }

        public bool FusionDeploymentActivate()
        {
            if (CheckWhetherNegated(true, true, CardType.Spell)) return false;
            if (FusionDeploymentSpSummonTarget() > 0)
            {
                SelectSTPlace(Card, true);
                return true;
            }

            return false;
        }

        public int FusionDeploymentSpSummonTarget()
        {
            if (CheckRemainInDeck(CardId.BlazingCartesiaTheVirtuous) > 0 && Bot.HasInExtra(CardId.GranguignolTheDuskDragon))
            {
                if (Bot.Hand.Any(c => c.IsMonster() && c.HasAttribute(CardAttribute.Light | CardAttribute.Dark)))
                {
                    return CardId.BlazingCartesiaTheVirtuous;
                }
            }
            if (CheckRemainInDeck(CardId.FallenOfAlbaz) > 0 && CheckAlbazFusion(Card))
            {
                return CardId.FallenOfAlbaz;
            }
            return 0;
        }

        public bool BrandedInWhiteActivate()
        {
            if (Card.Location == CardLocation.Grave)
            {
                if (CheckWhetherNegated(true, false, CardType.Spell)) return false;
                activatedCardIdList.Add(Card.Id + 1);
                SelectSTPlace(Card);
                return true;
            } else
            {
                if (BrandedInWhiteActivateCheck())
                {
                    activatedCardIdList.Add(Card.Id);
                    SelectSTPlace(Card, true);
                    return true;
                }
            }
            return false;
        }

        public bool BrandedInWhiteActivateCheck()
        {
            // TODO
            return true;
        }

        public bool BrandedFusionActivate()
        {
            if (BrandedFusionActivateCheck())
            {
                SelectSTPlace(Card, true);
                activatedCardIdList.Add(Card.Id);
                return true;
            }
            return false;
        }

        public bool BrandedFusionActivateCheck(bool endPhaseCheck = true)
        {
            if (CheckWhetherNegated(true, true, CardType.Spell) || activatedCardIdList.Contains(CardId.BrandedFusion)) return false;
            if (!Bot.HasInHandOrHasInMonstersZone(CardId.FallenOfAlbaz) && CheckRemainInDeck(CardId.FallenOfAlbaz) == 0) return false;
            if (endPhaseCheck && Duel.Phase >= DuelPhase.End) return false;
            // TODO
            return true;
        }

        public bool GoldSarcophagusActivate()
        {
            // TODO
            return false;
        }

        public bool FoolishBurialActivate()
        {
            // TODO
            return false;
        }

        public bool CalledbytheGraveActivate()
        {
            if (CheckWhetherNegated() || !CheckLastChainShouldNegated()) return false;
            if (CheckAtAdvantage() && Duel.LastChainPlayer == 1 && Util.GetLastChainCard().IsCode(_CardId.MaxxC))
            {
                return false;
            }
            if (Duel.LastChainPlayer == 1)
            {
                // negate
                if (Util.GetLastChainCard().IsMonster())
                {
                    int code = Util.GetLastChainCard().GetOriginCode();
                    if (code == 0) return false;
                    if (DefaultCheckWhetherCardIdIsNegated(code)) return false;
                    if (Util.GetLastChainCard().IsCode(_CardId.MaxxC) && CheckAtAdvantage())
                    {
                        return false;
                    }
                    ClientCard graveTarget = Enemy.Graveyard.GetFirstMatchingCard(card => card.IsMonster() && card.GetOriginCode() == code);
                    if (graveTarget != null)
                    {
                        if (!(Card.Location == CardLocation.SpellZone))
                        {
                            SelectSTPlace(null, true);
                        }
                        AI.SelectCard(graveTarget);
                        return true;
                    }
                }

                // banish target
                foreach (ClientCard cards in Enemy.Graveyard)
                {
                    if (Duel.ChainTargets.Contains(cards) && cards.IsMonster())
                    {
                        if (!(Card.Location == CardLocation.SpellZone))
                        {
                            SelectSTPlace(null, true);
                        }
                        int code = cards.Id;
                        AI.SelectCard(cards);
                        return true;
                    }
                }

                // become targets
                if (Duel.ChainTargets.Contains(Card))
                {
                    List<ClientCard> enemyMonsters = Enemy.Graveyard.GetMatchingCards(card => card.IsMonster()).ToList();
                    if (enemyMonsters.Count() > 0)
                    {
                        enemyMonsters.Sort(CardContainer.CompareCardAttack);
                        enemyMonsters.Reverse();
                        int code = enemyMonsters[0].Id;
                        AI.SelectCard(code);
                        return true;
                    }
                }
            }

            // avoid danger monster in grave
            if (Duel.LastChainPlayer == 1) return false;
            List<ClientCard> targets = GetDangerousCardinEnemyGrave(true);
            if (targets.Count() > 0)
            {
                int code = targets[0].Id;
                if (!(Card.Location == CardLocation.SpellZone))
                {
                    SelectSTPlace(null, true);
                }
                AI.SelectCard(code);
                return true;
            }

            return false;
        }

        public bool BrandedInHighSpiritsActivate()
        {
            if (Card.Location == CardLocation.Grave)
            {
                if (CheckWhetherNegated(true, false, CardType.Spell)) return false;
                activatedCardIdList.Add(Card.Id);
                return true;
            } else
            {
                if (BrandedInHighSpiritsActivateCheck())
                {
                    activatedCardIdList.Add(Card.Id);
                    SelectSTPlace(Card, true);
                    return true;
                }
            }
            return false;
        }

        public bool BrandedInHighSpiritsActivateCheck()
        {
            if (CheckWhetherNegated(true, true, CardType.Spell) || activatedCardIdList.Contains(CardId.BrandedInHighSpirits)) return false;
            // TODO
            return false;
        }

        public bool BrandedOpeningActivate()
        {
            if (CheckWhetherNegated(true, true, CardType.Spell)) return false;
            if (Bot.HasInHand(CardId.AlbionTheShroudedDragon) && !CheckWhetherWillbeRemoved() && !activatedCardIdList.Contains(CardId.AlbionTheShroudedDragon)) return false;
            bool goal = CheckRemainInDeck(CardId.AluberTheJesterOfDespia) > 0 && !activatedCardIdList.Contains(CardId.AluberTheJesterOfDespia) && !enemyActivateLockBird;
            goal |= CheckRemainInDeck(CardId.GuidingQuemTheVirtuous) > 0;
            if (goal)
            {
                SelectSTPlace(Card, true);
                activatedCardIdList.Add(Card.Id);
                return true;
            }
            return false;
        }

        public bool CrossoutDesignatorActivate()
        {
            if (CheckWhetherNegated() || !CheckLastChainShouldNegated()) return false;
            // negate 
            if (Duel.LastChainPlayer == 1 && Util.GetLastChainCard() != null)
            {
                int code = Util.GetLastChainCard().Id;
                int alias = Util.GetLastChainCard().Alias;
                if (alias != 0 && alias - code < 10) code = alias;
                if (code == 0) return false;
                if (DefaultCheckWhetherCardIdIsNegated(code)) return false;
                if (CheckRemainInDeck(code) > 0)
                {
                    if (!(Card.Location == CardLocation.SpellZone))
                    {
                        SelectSTPlace(null, true);
                    }
                    AI.SelectAnnounceID(code);
                    return true;
                }
            }
            return false;
        }

        public bool BrandedInRedActivate()
        {
            ClientCard targetCard = BrandedInRedActivateCheck();
            if (targetCard != null)
            {
                AI.SelectCard(targetCard);
                activatedCardIdList.Add(Card.Id);
                SelectSTPlace(Card, true);
                return true;
            }
            return false;
        }

        public ClientCard BrandedInRedActivateCheck()
        {
            if (CheckWhetherNegated(true, true, CardType.Spell) || activatedCardIdList.Contains(CardId.BrandedInRed)) return null;
            // TODO
            return null;
        }

        public bool BrandedLostActivate()
        {
            if (Card.Location == CardLocation.SpellZone && Card.IsFaceup())
            {
                // search
                return true;
            }
            if (CheckWhetherNegated(true, true, CardType.Spell)) return false;
            if (!summoned && Bot.HasInHand(CardId.FallenOfAlbaz) && CheckAlbazFusion() && Bot.Hand.Count() < 3) return false;
            SelectSTPlace(Card, true);
            return true;
        }

        public bool InfiniteImpermanenceActivate()
        {
            if (CheckWhetherNegated()) return false;

            ClientCard LastChainCard = Util.GetLastChainCard();

            // negate spells
            if (Card.Location == CardLocation.SpellZone)
            {
                int this_seq = -1;
                int that_seq = -1;
                for (int i = 0; i < 5; ++i)
                {
                    if (Bot.SpellZone[i] == Card) this_seq = i;
                    if (LastChainCard != null
                        && LastChainCard.Controller == 1 && LastChainCard.Location == CardLocation.SpellZone && Enemy.SpellZone[i] == LastChainCard) that_seq = i;
                    else if (Duel.Player == 0 && Util.GetProblematicEnemySpell() != null
                        && Enemy.SpellZone[i] != null && Enemy.SpellZone[i].IsFloodgate()) that_seq = i;
                }
                if ((this_seq * that_seq >= 0 && this_seq + that_seq == 4)
                    || Util.IsChainTarget(Card)
                    || (LastChainCard != null && LastChainCard.Controller == 1 && LastChainCard.IsCode(_CardId.HarpiesFeatherDuster)))
                {
                    ClientCard target = GetProblematicEnemyMonster(canBeTarget: true);
                    if (target != null)
                    {
                        AI.SelectCard(target);
                    }
                    else
                    {
                        AI.SelectCard(Enemy.GetMonsters());
                    }
                    infiniteImpermanenceList.Add(this_seq);
                    return true;
                }
            }

            // negate monster
            List<ClientCard> shouldNegateList = GetMonsterListForTargetNegate(true, CardType.Trap);
            if (shouldNegateList.Count() > 0)
            {
                ClientCard negateTarget = shouldNegateList[0];
                currentNegateMonsterList.Add(negateTarget);

                if (Card.Location == CardLocation.SpellZone)
                {
                    for (int i = 0; i < 5; ++i)
                    {
                        if (Bot.SpellZone[i] == Card)
                        {
                            infiniteImpermanenceList.Add(i);
                            break;
                        }
                    }
                }
                if (Card.Location == CardLocation.Hand)
                {
                    SelectSTPlace(Card, true);
                }
                AI.SelectCard(negateTarget);
                return true;
            }

            return false;
        }

        public bool BrightestBlazingBrandedKingActivate()
        {
            // TODO
            return false;
        }

        public bool BrandedBeastActivate()
        {
            // TODO
            return false;
        }

        public bool BrandedRetributionActivate()
        {
            // TODO
            return false;
        }

        public bool GuardianChimeraActivate()
        {
            // TODO
            return false;
        }

        public bool AlbionTheSanctifireDragonActivate()
        {
            // TODO
            return false;
        }

        public bool MirrorjadeTheIcebladeDragonActivate()
        {
            // TODO
            return false;
        }

        public bool BorreloadFuriousDragonActivate()
        {
            // TODO
            return false;
        }

        public bool LubellionTheSearingDragonActivate()
        {
            // TODO
            return false;
        }

        public bool AlbaLenatusTheAbyssDragonSpSummon()
        {
            // use albaz + enemy's dragon monster
            List<ClientCard> enemyDragon = Enemy.GetMonsters().Where(c => c != null && c.IsFaceup() && !cannotBeFusionMaterialIdList.Contains(c.Id) && c.HasRace(CardRace.Dragon)).ToList();
            if (enemyDragon.Count() > 0)
            {
                bool successFlag = enemyDragon.Count() > 1;
                int bestBotPower = Util.GetBestAttack(Bot);
                successFlag |= enemyDragon.Any(c => c.GetDefensePower() >= bestBotPower);
                if (successFlag)
                {
                    return true;
                }
            }
            // TODO
            return false;
        }

        public bool AlbaLenatusTheAbyssDragonActivate()
        {
            if (CheckWhetherNegated(true, false, CardType.Monster)) return false;
            activatedCardIdList.Add(Card.Id);
            return true;
        }

        public bool GranguignolTheDuskDragonActivate()
        {
            // TODO
            return false;
        }
        
        public bool DespianQuaeritisActivate()
        {
            // TODO
            return false;
        }

        public bool SprindTheIrondashDragonActivate()
        {
            // TODO
            return false;
        }

        public bool TitanikladTheAshDragonActivate()
        {
            // TODO
            return false;
        }

        public bool RindbrummTheStrikingDragonActivate()
        {
            // TODO
            return false;
        }

        public bool AlbionTheBrandedDragonActivate()
        {
            // TODO
            return false;
        }

        public bool DespianLuluwalilithActivate()
        {
            // TODO
            return false;
        }

        public bool SpellSetCheck()
        {
            if (Duel.Phase == DuelPhase.Main1 && Bot.HasAttackingMonster() && Duel.Turn > 1) return false;

            // select place
            if ((Card.IsTrap() || Card.HasType(CardType.QuickPlay)))
            {
                List<int> avoid_list = new List<int>();
                int setFornfiniteImpermanence = 0;
                for (int i = 0; i < 5; ++i)
                {
                    if (Enemy.SpellZone[i] != null && Enemy.SpellZone[i].IsFaceup() && Bot.SpellZone[4 - i] == null)
                    {
                        avoid_list.Add(4 - i);
                        setFornfiniteImpermanence += (int)System.Math.Pow(2, 4 - i);
                    }
                }
                if (Bot.HasInHand(_CardId.InfiniteImpermanence))
                {
                    if (Card.IsCode(_CardId.InfiniteImpermanence))
                    {
                        AI.SelectPlace(setFornfiniteImpermanence);
                        return true;
                    }
                    else
                    {
                        SelectSTPlace(Card, false, avoid_list);
                        return true;
                    }
                }
                else
                {
                    SelectSTPlace();
                }
                return true;
            }

            else if (Enemy.HasInSpellZone(_CardId.AntiSpellFragrance, true) || Bot.HasInSpellZone(_CardId.AntiSpellFragrance, true))
            {
                if (Card.IsSpell() && !Bot.HasInSpellZone(Card.Id))
                {
                    SelectSTPlace();
                    return true;
                }
            }

            return false;
        }
    }
}