﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace VýukovýProgramMobile.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel() 
        {
            Topic = "Vyjmenovaná slova po b";
            Questions = new Dictionary<string, string>();
            windowBackgroundColor = Color.Cyan;
            OnListTapCommand = new Command(OnListTap);
            OnPlayTapCommand = new Command(OnPlayTap);
            OnAnswerTapCommand = new Command(OnAnswerTap);
            OnEndTapCommand = new Command(OnEndTap);
            OnResetTapCommand = new Command(OnResetTap);
            IsMainLayoutVisible = true;
            IsVyjmenovanáSlovaExerciseLayoutVisible = false;
            isScoreLayoutVisible = false;
            //Questions po b-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            B.Add("ab_ch věděl", "y");
            B.Add("přibít hřeb_k", "í");
            B.Add("mladá kob_lka", "y");
            B.Add("ob_čej je zvyk", "y");
            B.Add("b_lé květy", "í");
            B.Add("měli b_chom jít", "y");
            B.Add("ob_val domek", "ý");
            B.Add("odb_la půlnoc", "i");
            B.Add("odb_la jsi úkol", "y");
            B.Add("nebuď vyb_ravý", "í");
            B.Add("zab_té zvíře", "i");
            B.Add("živá b_tost", "y");
            B.Add("Eva b_la Lídu", "i");
            B.Add("zb_tek polévky", "y");
            B.Add("přebytek ob_lí", "i");
            B.Add("nouze je b_da", "í");
            B.Add("b_la na horách", "y");
            B.Add("do kob_lis", "y");
            B.Add("předb_hal nás", "í");
            B.Add("b_valý prezident", "ý");
            B.Add("zalíb_l se mi", "i");
            B.Add("mladý b_ček", "ý");
            B.Add("útulný b_t", "y");
            B.Add("nikoho nezb_l", "y");
            B.Add("ob_vatel Brna", "y");
            B.Add("Sýr už nezb_l", "y");
            B.Add("v Přib_slavi", "y");
            B.Add("vyb_rá dárek", "í");
            B.Add("vaječný b_lek", "í");
            B.Add("příjemné b_dlení", "y");
            //Questions po l-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            L.Add("pl_tvá vodou", "ý");
            L.Add("l_sá hora", "y");
            L.Add("prudký l_ják", "i");
            L.Add("skoro se zal_ká", "y");
            L.Add("pol_bek", "i");
            L.Add("měla l_zátko", "í");
            L.Add("sl_bil mi to", "í");
            L.Add("bl_skavé šperky", "ý");
            L.Add("boty od hl_ny", "í");
            L.Add("voda pl_ne", "y");
            L.Add("l_tkový sval", "ý");
            L.Add("na rušné ul_ci", "i");
            L.Add("l_mec košile", "í");
            L.Add("hračky z pl_še", "y");
            L.Add("l_čí pasti", "í");
            L.Add("ml_t kávu", "í");
            L.Add("větrný ml_n", "ý");
            L.Add("sl_ší vzlykot", "y");
            L.Add("dobré l_vance", "í");
            L.Add("pel_ňkový čaj", "y");
            L.Add("černé hol_nky", "í");
            L.Add("skl_čko", "í");
            L.Add("světlo bl_kalo", "i");
            L.Add("pl_nový sporák", "y");
            L.Add("ml_nářka", "y");
            L.Add("sl_mák", "i");
            L.Add("pl_seň", "í");
            L.Add("l_skový ořech", "í");
            L.Add("učí se l_žovat", "y");
            L.Add("nal_tý čaj", "i");
            //Questions po m-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            M.Add("malá m_šička", "y");
            M.Add("m_lná zpráva", "y");
            M.Add("horský průsm_k", "y");
            M.Add("už se sm_řili", "í");
            M.Add("om_tnout dům", "í");
            M.Add("není neom_lný", "y");
            M.Add("ochm_řený", "ý");
            M.Add("neum_tý talíř", "y");
            M.Add("Láďa m_jí cíl", "í");
            M.Add("m_jí si ruce", "y");
            M.Add("odem_kání auta", "y");
            M.Add("m_luje léto", "i");
            M.Add("km_nový chléb", "í");
            M.Add("barevný m_č", "í");
            M.Add("housle a sm_čec", "y");
            M.Add("v Litom_šli", "y");
            M.Add("udělit m_lost", "i");
            M.Add("malé sem_nko", "í");
            M.Add("na hlem_ždě", "ý");
            M.Add("vítr jim sm_kl", "ý");
            M.Add("už se stm_vá", "í");
            M.Add("sm_šený les", "í");
            M.Add("prům_slová zóna", "y");
            M.Add("dětský sm_ch", "í");
            M.Add("m_cení stromů", "ý");
            M.Add("lídské sm_sly", "y");
            M.Add("neúm_slný čin", "y");
            M.Add("zam_chal čaj", "í");
            M.Add("nová m_šlenka", "y");
            M.Add("zm_lil jsem se", "ý");
            //Questions po p-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            P.Add("sojčí p_rko", "í");
            P.Add("dítě klop_tá", "ý");
            P.Add("třp_tivý šperk", "y");
            P.Add("zaječí p_sk", "y");
            P.Add("malé p_smeno", "í");
            P.Add("p_lník na nehty", "i");
            P.Add("nap_navý film", "í");
            P.Add("je přep_chový", "y");
            P.Add("vrbová p_šťalka", "í");
            P.Add("třp_t hvězd", "y");
            P.Add("tupá p_la", "i");
            P.Add("za trest p_ká", "y");
            P.Add("na netop_ry", "ý");
            P.Add("velká p_cha", "ý");
            P.Add("přep_š to", "i");
            P.Add("je z p_tloviny", "y");
            P.Add("zlato se třp_tí", "y");
            P.Add("p_semná práce", "í");
            P.Add("p_snička", "í");
            P.Add("p_skoviště", "í");
            P.Add("malý p_tlíček", "y");
            P.Add("hravá op_čka", "i");
            P.Add("p_tel brambor", "y");
            P.Add("nep_je pivo", "i");
            P.Add("klop_tnutí", "ý");
            P.Add("p_hy na nose", "i");
            P.Add("netop_ří let", "ý");
            P.Add("nap_jte se", "i");
            P.Add("sudokop_tník", "y");
            P.Add("nap_š nám", "i");
            //Questions po s-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            S.Add("s_kora koňadra", "ý");
            S.Add("houkání s_čka", "ý");
            S.Add("byl nenas_tný", "y");
            S.Add("s_lný vítr", "i");
            S.Add("s_dlo vlády", "í");
            S.Add("doupě s_sla", "y");
            S.Add("zápach s_ry", "í");
            S.Add("tis_c korun", "í");
            S.Add("houba s_rovinka", "y");
            S.Add("přis_p cukr", "y");
            S.Add("os_ny ječmene", "i");
            S.Add("nes_čkuj", "ý");
            S.Add("je s_chravo", "y");
            S.Add("s_slí zásoby", "y");
            S.Add("kuchyňská s_ta", "í");
            S.Add("pos_luj svaly", "i");
            S.Add("pros_val písek", "í");
            S.Add("tichý s_kot", "y");
            S.Add("těžit s_ru", "í");
            S.Add("ty nenas_to", "y");
            S.Add("vys_lá sygnál", "í");
            S.Add("us_chající keř", "y");
            S.Add("s_sel je savec", "y");
            S.Add("s_vý holub", "i");
            S.Add("pos_pat silnici", "y");
            S.Add("plátkový s_r", "ý");
            S.Add("Dan zes_nal", "i");
            S.Add("s_ťka na motýly", "í");
            S.Add("má os_pky", "y");
            S.Add("mladý s_ček", "ý");
            //Questions po v-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            V.Add("v okně se sv_tí", "í");
            V.Add("v_počítej to", "y");
            V.Add("nev_děla nás", "i");
            V.Add("ještě nesv_tá", "í");
            V.Add("v_soká věž", "y");
            V.Add("kovářská v_heň", "ý");
            V.Add("žv_kala seno", "ý");
            V.Add("zav_novačka", "i");
            V.Add("v_tři podlahu", "y");
            V.Add("v_děli výra", "ý");
            V.Add("chvilička", "i");
            V.Add("nev_domí lidé", "i");
            V.Add("přežv_kovat", "y");
            V.Add("vodní v_r", "í");
            V.Add("zimní v_prodej", "ý");
            V.Add("mořská v_la", "í");
            V.Add("obv_kle vítězí", "y");
            V.Add("v_nes odpadky", "y");
            V.Add("četla nov_ny", "i");
            V.Add("v_tržený zub", "y");
            V.Add("hrát na klav_r", "í");
            V.Add("bydlí ve v_le", "i");
            V.Add("zv_knout si", "y");
            V.Add("oční v_čka", "í");
            V.Add("v_dra je šelma", "y");
            V.Add("v_čitky svědomí", "ý");
            V.Add("hrají v_bíjenou", "y");
            V.Add("cena pro v_těze", "í");
            V.Add("v_fuk auta", "ý");
            V.Add("smál se a v_skal", "ý");
            //Questions po z-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Z.Add("přijď brz_", "y");
            Z.Add("měl z_mnici", "i");
            Z.Add("brz_čko přijde", "i");
            Z.Add("český jaz_k", "y");
            Z.Add("podez_rá ho", "í");
            Z.Add("z_skali čas", "í");
            Z.Add("cizojaz_čný", "y");
            Z.Add("z_mní kabát", "i");
            Z.Add("ten se něco naz_vá", "í");
            Z.Add("tak ho naz_vá", "ý");
            Z.Add("nečekaný z_sk", "i");
            Z.Add("z_moviště ptáků", "i");
            Z.Add("oz_val se hluk", "ý");
            Z.Add("přijedu z_tra", "í");
            Z.Add("pořád z_val", "í");
            Z.Add("jel do Ruz_ně", "y");
            Z.Add("bez_nkový keř", "i");
            Z.Add("zlé jez_nky", "i");
            Z.Add("teď se neoz_vá", "ý");
            Z.Add("vyz_val k tanci", "ý");
            Z.Add("dnešek a z_třek", "í");
            Z.Add("nízká z_dka", "í");
            Z.Add("kočičí jaz_čky", "ý");
            Z.Add("muz_kant", "i");
            Z.Add("moje viz_tka", "i");
            Z.Add("ruz_ňská silnice", "y");
            Z.Add("jaz_kověda", "y");
            Z.Add("na podz_m", "i");
            Z.Add("je moc brz_", "y");
            Z.Add("naz_vej ho tak", "ý");
            //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }

        Random nc = new Random();
        int num;

        Color windowBackgroundColor;
        public Color WindowBackgroundColor
        {
            get => windowBackgroundColor;
            set { SetProperty(ref windowBackgroundColor, value);}
        }
        public ICommand OnListTapCommand { get; set; }
        public ICommand OnPlayTapCommand { get; set; }
        public ICommand OnAnswerTapCommand { get; set; }
        public ICommand OnEndTapCommand { get; set; }
        public ICommand OnResetTapCommand { get; set; }

        bool isMainLayoutVisible;
        public bool IsMainLayoutVisible
        {
            get => isMainLayoutVisible;
            set { SetProperty(ref isMainLayoutVisible, value); }
        }
        bool isVyjmenovanáSlovaExerciseLayoutVisible;
        public bool IsVyjmenovanáSlovaExerciseLayoutVisible
        {
            get => isVyjmenovanáSlovaExerciseLayoutVisible;
            set { SetProperty(ref isVyjmenovanáSlovaExerciseLayoutVisible, value); }
        }
        bool isScoreLayoutVisible;
        public bool IsScoreLayoutVisible
        {
            get => isScoreLayoutVisible;
            set { SetProperty(ref isScoreLayoutVisible, value); }
        }
        string btnI;
        public string BtnI
        {
            get => btnI;
            set { SetProperty(ref btnI, value); }
        }
        string btnY;
        public string BtnY
        {
            get => btnY;
            set { SetProperty(ref btnY, value); }
        }

        public void OnListTap(object sender)
        {
            TextCell tc = (TextCell)sender;
            Topic = tc.Text;
            Debug.WriteLine(Topic);
            switch (Topic)
            {
                case string a when a.Contains("Vyjmenovaná slova"):
                    windowBackgroundColor = Color.Cyan;
                    break;
                default:
                    break;
            }
        }

        public void OnPlayTap() 
        {
            Score = 0;
            Lives = 3;
            switch (Topic)
            {
                case string a when a.Contains("Vyjmenovaná slova"):
                    switch (Topic)
                    {
                        case "Vyjmenovaná slova po b":
                            Questions = B;
                            break;
                        case "Vyjmenovaná slova po l":
                            Questions = L;
                            break;
                        case "Vyjmenovaná slova po m":
                            Questions = M;
                            break;
                        case "Vyjmenovaná slova po p":
                            Questions = P;
                            break;
                        case "Vyjmenovaná slova po s":
                            Questions = S;
                            break;
                        case "Vyjmenovaná slova po v":
                            Questions = V;
                            break;
                        case "Vyjmenovaná slova po z":
                            Questions = Z;
                            break;
                        case "Vyjmenovaná slova - opakování":
                            Questions = new Dictionary<string, string>();
                            foreach (KeyValuePair<string, string> i in B)
                            {
                                Questions.Add(i.Key, i.Value);
                            }
                            foreach (var i in L)
                            {
                                Questions.Add(i.Key, i.Value);
                            }
                            foreach (var i in M)
                            {
                                Questions.Add(i.Key, i.Value);
                            }
                            foreach (var i in P)
                            {
                                Questions.Add(i.Key, i.Value);
                            }
                            foreach (var i in S)
                            {
                                Questions.Add(i.Key, i.Value);
                            }
                            foreach (var i in V)
                            {
                                Questions.Add(i.Key, i.Value);
                            }
                            foreach (var i in Z)
                            {
                                Questions.Add(i.Key, i.Value);
                            }
                            break;
                        default:
                            break;
                    }
                    IsMainLayoutVisible = false;
                    IsVyjmenovanáSlovaExerciseLayoutVisible = true;

                    num = nc.Next(0, Questions.Count);
                    Question = Questions.ElementAt(num).Key;
                    Answer = Questions.ElementAt(num).Value;

                    switch (Answer)
                    {
                        case "i":
                            BtnI = "i";
                            BtnY = "y";
                            break;
                        case "y":
                            BtnI = "i";
                            BtnY = "y";
                            break;
                        case "í":
                            BtnI = "í";
                            BtnY = "ý";
                            break;
                        case "ý":
                            BtnI = "í";
                            BtnY = "ý";
                            break;
                        case "I":
                            BtnI = "I";
                            BtnY = "Y";
                            break;
                        case "Y":
                            BtnI = "I";
                            BtnY = "Y";
                            break;
                        case "Í":
                            BtnI = "Í";
                            BtnY = "Ý";
                            break;
                        case "Ý":
                            BtnI = "Í";
                            BtnY = "Ý";
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        public void OnAnswerTap(object sender)
        {
            if (Answer == (sender as Button).Text.ToString())
            {
                Score++;
                Questions.Remove(Question);
                if (Questions.Count == 0)
                {
                    OnEndTap();
                    return;
                }
            }
            else
            {
                Lives--;
                if (Lives == 0) 
                { 
                    OnEndTap();
                    return;
                }
                
            }

            num = nc.Next(0, Questions.Count);
            Question = Questions.ElementAt(num).Key;
            Answer = Questions.ElementAt(num).Value;

            switch (Answer)
            {
                case "i":
                    BtnI = "i";
                    BtnY = "y";
                    break;
                case "y":
                    BtnI = "i";
                    BtnY = "y";
                    break;
                case "í":
                    BtnI = "í";
                    BtnY = "ý";
                    break;
                case "ý":
                    BtnI = "í";
                    BtnY = "ý";
                    break;
                case "I":
                    BtnI = "I";
                    BtnY = "Y";
                    break;
                case "Y":
                    BtnI = "I";
                    BtnY = "Y";
                    break;
                case "Í":
                    BtnI = "Í";
                    BtnY = "Ý";
                    break;
                case "Ý":
                    BtnI = "Í";
                    BtnY = "Ý";
                    break;
                default:
                    break;
            }
        }
        public void OnEndTap()
        {
            IsVyjmenovanáSlovaExerciseLayoutVisible = false;
            IsScoreLayoutVisible = true;
        }

        public void OnResetTap()
        {
            IsScoreLayoutVisible = false;
            IsMainLayoutVisible = true;
        }
    }
}
