using System;
using System.Collections.Generic;

namespace Heroes.ReplayParser
{
    public class Player
    {
        private int[] _color = new int[0];
        private Talent[] _talents = new Talent[0];
        private bool _isSilenced = false;
        private string _mountAndMountTint = null;
        private List<Unit> _heroUnits = new List<Unit>();
        private ScoreResult _scoreResult = new ScoreResult();
        private List<UpgradeEvent> _upgradeEvents = new List<UpgradeEvent>();
        private Dictionary<string, bool> _miscellaneousUpgradeEventDictionary = new Dictionary<string, bool>();
        private Dictionary<string, int> _miscellaneousScoreResultEventDictionary = new Dictionary<string, int>();
        private Dictionary<string, bool> _playerCollectionDictionary = new Dictionary<string, bool>();
        private string _skinAndSkinTint = null;

        /// <summary>
        /// Gets or sets the Battle.NET region of a player.
        /// </summary>
        public int BattleNetRegionId { get; set; }

        /// <summary>
        /// Gets or sets the Battle.NET Sub-ID of a player, describing the URI to find the player profile. 
        /// </summary>
        public int BattleNetSubId { get; set; }

        /// <summary>
        /// Gets or sets the Battle.NET ID of a player, describing the URI to find the player profile.
        /// </summary>
        public int BattleNetId { get; set; }

        /// <summary>
        /// Gets or sets the player's color.
        /// </summary>
        public int[] Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// Gets or sets the difficulty of a computer player.
        /// </summary>
        public Difficulty Difficulty { get; set; }

        /// <summary>
        /// Gets or sets the player's handicap.
        /// </summary>
        public int Handicap { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the player won the game.
        /// </summary>
        public bool IsWinner { get; set; }

        /// <summary>
        /// Gets or sets the player's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the BattleTag (Numbers only)
        /// </summary>
        public int BattleTag { get; set; }

        /// <summary>
        /// Gets or sets the type of player, whether he is human or computer.
        /// </summary>
        public PlayerType PlayerType { get; set; }

        /// <summary>
        /// Gets or sets the player's team number.
        /// </summary>
        public int Team { get; set; }

        /// <summary>
        /// Gets or sets whether the player was auto select or not
        /// </summary>
        public bool IsAutoSelect { get; set; }

        /// <summary>
        /// Gets or sets the player's character.
        /// </summary>
        public string Character { get; set; }

        /// <summary>
        /// Gets or sets the player's skin / skin tint.
        /// </summary>
        public string SkinAndSkinTint
        {
            get { return _skinAndSkinTint; }
            set { _skinAndSkinTint = value; }
        }

        /// <summary>
        /// Gets or sets the player's mount / mount tint.
        /// </summary>
        public string MountAndMountTint
        {
            get { return _mountAndMountTint; }
            set { _mountAndMountTint = value; }
        }

        /// <summary>
        /// Gets or sets the player's character level.
        /// </summary>
        public int CharacterLevel { get; set; }

        /// <summary>
        /// Gets or sets if the player has been given the silenced penalty
        /// </summary>
        public bool IsSilenced
        {
            get { return _isSilenced; }
            set { _isSilenced = value; }
        }

        /// <summary>
        /// Gets or sets the player's selected Hero talents
        /// </summary>
        public Talent[] Talents
        {
            get { return _talents; }
            set { _talents = value; }
        }

        /// <summary>
        /// Gets or sets the player's in game Hero units.
        /// </summary>
        public List<Unit> HeroUnits
        {
            get { return _heroUnits; }
            set { _heroUnits = value; }
        }

        /// <summary>
        /// Gets or sets the player's standard end game score result statistics
        /// </summary>
        public ScoreResult ScoreResult
        {
            get { return _scoreResult; }
            set { _scoreResult = value; }
        }

        /// <summary>
        /// Gets or sets the player's Upgrade Events
        /// </summary>
        public List<UpgradeEvent> UpgradeEvents
        {
            get { return _upgradeEvents; }
            set { _upgradeEvents = value; }
        }

        /// <summary>
        /// Gets or sets the player's miscellaneous upgrade events
        /// </summary>
        public Dictionary<string, bool> MiscellaneousUpgradeEventDictionary
        {
            get { return _miscellaneousUpgradeEventDictionary; }
            set { _miscellaneousUpgradeEventDictionary = value; }
        }

        /// <summary>
        /// Gets or sets the player's miscellaneous end game score result statistics
        /// </summary>
        public Dictionary<string, int> MiscellaneousScoreResultEventDictionary
        {
            get { return _miscellaneousScoreResultEventDictionary; }
            set { _miscellaneousScoreResultEventDictionary = value; }
        }

        /// <summary>
        /// Gets or sets the player's collection, no longer available since 56175
        /// </summary>
        public Dictionary<string, bool> PlayerCollectionDictionary
        {
            get { return _playerCollectionDictionary; }
            set { _playerCollectionDictionary = value; }
        }

        /// <summary>
        /// Gets or sets the the player's party (same value, same party)
        /// </summary>
        public long PartyValue { get; set; }

        /// <summary>
        /// Gets or sets the player's TId (alternative to battletag)
        /// </summary>
        public string BattleNetTId { get; set; }

        /// <summary>
        /// Gets or sets the player's account level
        /// </summary>
        public int AccountLevel { get; set; }
    }

    public class ScoreResult
    {
        private List<MatchAwardType> _matchAwards = new List<MatchAwardType>();
        private TimeSpan _timeSpentDead = TimeSpan.Zero;
        private int _takedowns = 0;
        private int _level = 0;
        private int _soloKills = 0;
        private int _assists = 0;
        private int _deaths = 0;
        private int _highestKillStreak = 0;
        private int _heroDamage = 0;
        private int _siegeDamage = 0;
        private int _structureDamage = 0;
        private int _minionDamage = 0;
        private int _creepDamage = 0;
        private int _summonDamage = 0;
        private TimeSpan? _timeCCdEnemyHeroes = null;
        private int? _healing = null;
        private int _selfHealing = 0;
        private int? _damageTaken = null;
        private int _experienceContribution = 0;
        private int _townKills = 0;
        private int _mercCampCaptures = 0;
        private int _watchTowerCaptures = 0;
        private int _metaExperience = 0;

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public int Takedowns
        {
            get { return _takedowns; }
            set { _takedowns = value; }
        }

        public int SoloKills
        {
            get { return _soloKills; }
            set { _soloKills = value; }
        }

        public int Assists
        {
            get { return _assists; }
            set { _assists = value; }
        }

        public int Deaths
        {
            get { return _deaths; }
            set { _deaths = value; }
        }

        public int HighestKillStreak
        {
            get { return _highestKillStreak; }
            set { _highestKillStreak = value; }
        }

        public int HeroDamage
        {
            get { return _heroDamage; }
            set { _heroDamage = value; }
        }

        public int SiegeDamage
        {
            get { return _siegeDamage; }
            set { _siegeDamage = value; }
        }

        public int StructureDamage
        {
            get { return _structureDamage; }
            set { _structureDamage = value; }
        }

        public int MinionDamage
        {
            get { return _minionDamage; }
            set { _minionDamage = value; }
        }

        public int CreepDamage
        {
            get { return _creepDamage; }
            set { _creepDamage = value; }
        }

        public int SummonDamage
        {
            get { return _summonDamage; }
            set { _summonDamage = value; }
        }

        public TimeSpan? TimeCCdEnemyHeroes
        {
            get { return _timeCCdEnemyHeroes; }
            set { _timeCCdEnemyHeroes = value; }
        }

        public int? Healing
        {
            get { return _healing; }
            set { _healing = value; }
        }

        public int SelfHealing
        {
            get { return _selfHealing; }
            set { _selfHealing = value; }
        }

        public int? DamageTaken
        {
            get { return _damageTaken; }
            set { _damageTaken = value; }
        }

        public int ExperienceContribution
        {
            get { return _experienceContribution; }
            set { _experienceContribution = value; }
        }

        public int TownKills
        {
            get { return _townKills; }
            set { _townKills = value; }
        }

        public TimeSpan TimeSpentDead
        {
            get { return _timeSpentDead; }
            set { _timeSpentDead = value; }
        }

        public int MercCampCaptures
        {
            get { return _mercCampCaptures; }
            set { _mercCampCaptures = value; }
        }

        public int WatchTowerCaptures
        {
            get { return _watchTowerCaptures; }
            set { _watchTowerCaptures = value; }
        }

        public int MetaExperience
        {
            get { return _metaExperience; }
            set { _metaExperience = value; }
        } // Exp added to the player's Account and Hero level after the match

        public List<MatchAwardType> MatchAwards
        {
            get { return _matchAwards; }
            set { _matchAwards = value; }
        }
    }

    public class Talent
    {
        private string _talentName = null;
        public int TalentID { get; set; }

        public string TalentName
        {
            get { return _talentName; }
            set { _talentName = value; }
        }

        public TimeSpan TimeSpanSelected { get; set; }
    }

    public class UpgradeEvent
    {
        public TimeSpan TimeSpan { get; set; }
        public UpgradeEventType UpgradeEventType { get; set; }
        public int Value { get; set; }
    }

    public enum PlayerType
    {
        Human,
        Computer,
        Spectator
    }

    public enum Difficulty
    {
        Unknown,
        Beginner,
        Recruit,
        Adept,
        Veteran,
        Elite
    }

    public enum UpgradeEventType
    {
        NovaSnipeMasterDamageUpgrade = 1,
        GallTalentDarkDescentUpgrade = 2,
        RegenMasterStacks = 3,
        MarksmanStacks = 4,
		WitchDoctorPlagueofToadsPandemicTalentCompletion = 5
	}

    public enum MatchAwardType
    {
        MVP = 1,

        HighestKillStreak = 2,
        MostXPContribution = 3,
        MostHeroDamageDone = 4,
        MostSiegeDamageDone = 5,
        MostDamageTaken = 6,
        MostHealing = 7,
        MostStuns = 8,
        MostMercCampsCaptured = 9,
        // MapSpecific = 10, - Instead of tracking this generic one, just check if the player has one of the other map-specific Match Awards above 1000
        
        MostKills = 11,
        HatTrick = 12,
        ClutchHealer = 13,
        MostProtection = 14,
        ZeroDeaths = 15,
        MostRoots = 16,
        ZeroOutnumberedDeaths = 17,
        MostDaredevilEscapes = 18,
        MostEscapes = 19,
        MostSilences = 20,
        MostTeamfightDamageTaken = 21,
        MostTeamfightHealingDone = 22,
        MostTeamfightHeroDamageDone = 23,
        MostVengeancesPerformed = 24,

        MostImmortalDamage = 1001,
        MostCoinsPaid = 1002,
        MostCurseDamageDone = 1003,
        MostDragonShrinesCaptured = 1004,
        MostDamageToPlants = 1005,
		MostSkullsCollected = 1006,
        MostDamageToMinions = 1007,
        MostTimeInTemple = 1008,
        MostGemsTurnedIn = 1009,
        MostAltarDamage = 1010,
        // Lost Cavern = 1011 - No map award
        MostDamageDoneToZerg = 1012,
        MostNukeDamageDone = 1013,
		MostTimePushing = 1016
    }
}