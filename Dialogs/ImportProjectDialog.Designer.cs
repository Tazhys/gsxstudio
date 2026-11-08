namespace GSX_Studio
{
	public partial class ImportProjectDialog : global::DevExpress.XtraEditors.XtraForm
	{
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.labelControl1 = new global::DevExpress.XtraEditors.LabelControl();
			this.ScriptPath = new global::DevExpress.XtraEditors.ComboBoxEdit();
			this.CreatorName = new global::DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new global::DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new global::DevExpress.XtraEditors.LabelControl();
			this.ConflictsHandling = new global::DevExpress.XtraEditors.ComboBoxEdit();
			this.ProjectsList = new global::DevExpress.XtraTreeList.TreeList();
			this.treeListColumn1 = new global::DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.progressBarControl1 = new global::DevExpress.XtraEditors.ProgressBarControl();
			this.StartImports = new global::DevExpress.XtraEditors.SimpleButton();
			this.AddProjects = new global::DevExpress.XtraEditors.SimpleButton();
			this.CancelImports = new global::DevExpress.XtraEditors.SimpleButton();
			this.barManager1 = new global::DevExpress.XtraBars.BarManager(this.components);
			this.barDockControlTop = new global::DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new global::DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new global::DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new global::DevExpress.XtraBars.BarDockControl();
			this.barButtonItem1 = new global::DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem2 = new global::DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem3 = new global::DevExpress.XtraBars.BarButtonItem();
			this.RContextMenu = new global::DevExpress.XtraBars.PopupMenu(this.components);
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			((global::System.ComponentModel.ISupportInitialize)this.ScriptPath.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CreatorName.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ConflictsHandling.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ProjectsList).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.progressBarControl1.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.barManager1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.RContextMenu).BeginInit();
			base.SuspendLayout();
			this.labelControl1.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location = new global::System.Drawing.Point(0xC, 0x152);
			this.labelControl1.Location = location;
			this.labelControl1.Name = "labelControl1";
			global::System.Drawing.Size size = new global::System.Drawing.Size(0x77, 0x10);
			this.labelControl1.Size = size;
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Default Script Name:";
			this.ScriptPath.EditValue = "maps\\mp\\gametypes\\_clientids.gsc";
			global::System.Drawing.Point location2 = new global::System.Drawing.Point(0xB4, 0x152);
			this.ScriptPath.Location = location2;
			this.ScriptPath.Name = "ScriptPath";
			global::DevExpress.XtraEditors.Controls.EditorButton[] buttons = new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton() { Kind = global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo }
			};
			this.ScriptPath.Properties.Buttons.AddRange(buttons);
			object[] items = new object[]
			{
				"aitype\\clientscripts\\enemy_dog_mp.csc",
				"aitype\\enemy_dog_mp.gsc",
				"character\\c_mp_german_shepherd_vest.gsc",
				"character\\c_mp_german_shepherd_vest_black.gsc",
				"character\\character_mp_german_shepherd.gsc",
				"character\\clientscripts\\c_mp_german_shepherd_vest.csc",
				"character\\clientscripts\\c_mp_german_shepherd_vest_black.csc",
				"character\\clientscripts\\character_mp_german_shepherd.csc",
				"clientscripts\\_radiant_live_update.csc",
				"clientscripts\\_radiant_live_update.gsc",
				"clientscripts\\mp\\_acousticsensor.csc",
				"clientscripts\\mp\\_acousticsensor.gsc",
				"clientscripts\\mp\\_ai_tank.csc",
				"clientscripts\\mp\\_ai_tank.gsc",
				"clientscripts\\mp\\_airsupport.csc",
				"clientscripts\\mp\\_airsupport.gsc",
				"clientscripts\\mp\\_ambient.csc",
				"clientscripts\\mp\\_ambient.gsc",
				"clientscripts\\mp\\_ambientpackage.csc",
				"clientscripts\\mp\\_ambientpackage.gsc",
				"clientscripts\\mp\\_audio.csc",
				"clientscripts\\mp\\_audio.gsc",
				"clientscripts\\mp\\_bouncingbetty.csc",
				"clientscripts\\mp\\_bouncingbetty.gsc",
				"clientscripts\\mp\\_burnplayer.csc",
				"clientscripts\\mp\\_burnplayer.gsc",
				"clientscripts\\mp\\_busing.csc",
				"clientscripts\\mp\\_busing.gsc",
				"clientscripts\\mp\\_callbacks.csc",
				"clientscripts\\mp\\_callbacks.gsc",
				"clientscripts\\mp\\_cameraspike.csc",
				"clientscripts\\mp\\_cameraspike.gsc",
				"clientscripts\\mp\\_claymore.csc",
				"clientscripts\\mp\\_claymore.gsc",
				"clientscripts\\mp\\_clientfaceanim_mp.csc",
				"clientscripts\\mp\\_clientfaceanim_mp.gsc",
				"clientscripts\\mp\\_counteruav.csc",
				"clientscripts\\mp\\_counteruav.gsc",
				"clientscripts\\mp\\_ctf.csc",
				"clientscripts\\mp\\_ctf.gsc",
				"clientscripts\\mp\\_decoy.csc",
				"clientscripts\\mp\\_decoy.gsc",
				"clientscripts\\mp\\_destructible.csc",
				"clientscripts\\mp\\_destructible.gsc",
				"clientscripts\\mp\\_dogs.csc",
				"clientscripts\\mp\\_dogs.gsc",
				"clientscripts\\mp\\_explode.csc",
				"clientscripts\\mp\\_explode.gsc",
				"clientscripts\\mp\\_explosive_bolt.csc",
				"clientscripts\\mp\\_explosive_bolt.gsc",
				"clientscripts\\mp\\_face_utility_mp.csc",
				"clientscripts\\mp\\_face_utility_mp.gsc",
				"clientscripts\\mp\\_filter.csc",
				"clientscripts\\mp\\_filter.gsc",
				"clientscripts\\mp\\_footsteps.csc",
				"clientscripts\\mp\\_footsteps.gsc",
				"clientscripts\\mp\\_fx.csc",
				"clientscripts\\mp\\_fx.gsc",
				"clientscripts\\mp\\_fxanim.csc",
				"clientscripts\\mp\\_fxanim.gsc",
				"clientscripts\\mp\\_global_fx.csc",
				"clientscripts\\mp\\_global_fx.gsc",
				"clientscripts\\mp\\_helicopter.csc",
				"clientscripts\\mp\\_helicopter.gsc",
				"clientscripts\\mp\\_helicopter_sounds.csc",
				"clientscripts\\mp\\_helicopter_sounds.gsc",
				"clientscripts\\mp\\_lights.csc",
				"clientscripts\\mp\\_lights.gsc",
				"clientscripts\\mp\\_load.csc",
				"clientscripts\\mp\\_load.gsc",
				"clientscripts\\mp\\_missile_drone.csc",
				"clientscripts\\mp\\_missile_drone.gsc",
				"clientscripts\\mp\\_missile_swarm.csc",
				"clientscripts\\mp\\_missile_swarm.gsc",
				"clientscripts\\mp\\_multi_extracam.csc",
				"clientscripts\\mp\\_multi_extracam.gsc",
				"clientscripts\\mp\\_music.csc",
				"clientscripts\\mp\\_music.gsc",
				"clientscripts\\mp\\_planemortar.csc",
				"clientscripts\\mp\\_planemortar.gsc",
				"clientscripts\\mp\\_players.csc",
				"clientscripts\\mp\\_players.gsc",
				"clientscripts\\mp\\_proximity_grenade.csc",
				"clientscripts\\mp\\_proximity_grenade.gsc",
				"clientscripts\\mp\\_qrdrone.csc",
				"clientscripts\\mp\\_qrdrone.gsc",
				"clientscripts\\mp\\_rcbomb.csc",
				"clientscripts\\mp\\_rcbomb.gsc",
				"clientscripts\\mp\\_remotemissile.csc",
				"clientscripts\\mp\\_remotemissile.gsc",
				"clientscripts\\mp\\_rewindobjects.csc",
				"clientscripts\\mp\\_rewindobjects.gsc",
				"clientscripts\\mp\\_riotshield.csc",
				"clientscripts\\mp\\_riotshield.gsc",
				"clientscripts\\mp\\_rotating_object.csc",
				"clientscripts\\mp\\_rotating_object.gsc",
				"clientscripts\\mp\\_satchel_charge.csc",
				"clientscripts\\mp\\_satchel_charge.gsc",
				"clientscripts\\mp\\_scrambler.csc",
				"clientscripts\\mp\\_scrambler.gsc",
				"clientscripts\\mp\\_sticky_grenade.csc",
				"clientscripts\\mp\\_sticky_grenade.gsc",
				"clientscripts\\mp\\_tacticalinsertion.csc",
				"clientscripts\\mp\\_tacticalinsertion.gsc",
				"clientscripts\\mp\\_teamset_seals.csc",
				"clientscripts\\mp\\_teamset_seals.gsc",
				"clientscripts\\mp\\_treadfx.csc",
				"clientscripts\\mp\\_treadfx.gsc",
				"clientscripts\\mp\\_trophy_system.csc",
				"clientscripts\\mp\\_trophy_system.gsc",
				"clientscripts\\mp\\_turret.csc",
				"clientscripts\\mp\\_turret.gsc",
				"clientscripts\\mp\\_utility.csc",
				"clientscripts\\mp\\_utility.gsc",
				"clientscripts\\mp\\_utility_code.csc",
				"clientscripts\\mp\\_utility_code.gsc",
				"clientscripts\\mp\\_vehicle.csc",
				"clientscripts\\mp\\_vehicle.gsc",
				"clientscripts\\mp\\_visionset_mgr.csc",
				"clientscripts\\mp\\_visionset_mgr.gsc",
				"clientscripts\\mp\\createfx\\mp_concert_fx.csc",
				"clientscripts\\mp\\createfx\\mp_nuketown_2020_fx.csc",
				"clientscripts\\mp\\gametypes\\conf.csc",
				"clientscripts\\mp\\gametypes\\conf.gsc",
				"clientscripts\\mp\\gametypes\\ctf.csc",
				"clientscripts\\mp\\gametypes\\ctf.gsc",
				"clientscripts\\mp\\gametypes\\dem.csc",
				"clientscripts\\mp\\gametypes\\dem.gsc",
				"clientscripts\\mp\\gametypes\\dm.csc",
				"clientscripts\\mp\\gametypes\\dm.gsc",
				"clientscripts\\mp\\gametypes\\dom.csc",
				"clientscripts\\mp\\gametypes\\dom.gsc",
				"clientscripts\\mp\\gametypes\\gun.csc",
				"clientscripts\\mp\\gametypes\\gun.gsc",
				"clientscripts\\mp\\gametypes\\hq.csc",
				"clientscripts\\mp\\gametypes\\hq.gsc",
				"clientscripts\\mp\\gametypes\\koth.csc",
				"clientscripts\\mp\\gametypes\\koth.gsc",
				"clientscripts\\mp\\gametypes\\oic.csc",
				"clientscripts\\mp\\gametypes\\oic.gsc",
				"clientscripts\\mp\\gametypes\\sas.csc",
				"clientscripts\\mp\\gametypes\\sas.gsc",
				"clientscripts\\mp\\gametypes\\sd.csc",
				"clientscripts\\mp\\gametypes\\sd.gsc",
				"clientscripts\\mp\\gametypes\\shrp.csc",
				"clientscripts\\mp\\gametypes\\shrp.gsc",
				"clientscripts\\mp\\gametypes\\tdm.csc",
				"clientscripts\\mp\\gametypes\\tdm.gsc",
				"clientscripts\\mp\\gametypes\\zclassic.csc",
				"clientscripts\\mp\\gametypes\\zclassic.gsc",
				"clientscripts\\mp\\mp_carrier.csc",
				"clientscripts\\mp\\mp_carrier.gsc",
				"clientscripts\\mp\\mp_dockside.csc",
				"clientscripts\\mp\\mp_dockside.gsc",
				"clientscripts\\mp\\mp_drone_fx.csc",
				"clientscripts\\mp\\mp_drone_fx.gsc",
				"clientscripts\\mp\\mp_express.csc",
				"clientscripts\\mp\\mp_express.gsc",
				"clientscripts\\mp\\mp_hijacked.csc",
				"clientscripts\\mp\\mp_hijacked.gsc",
				"clientscripts\\mp\\mp_hydro.csc",
				"clientscripts\\mp\\mp_hydro.gsc",
				"clientscripts\\mp\\mp_nuketown_2020.csc",
				"clientscripts\\mp\\mp_nuketown_2020.gsc",
				"clientscripts\\mp\\mp_nuketown_2020_amb.gsc",
				"clientscripts\\mp\\mp_nuketown_2020_fx.gsc",
				"clientscripts\\mp\\mp_overflow.csc",
				"clientscripts\\mp\\mp_overflow.gsc",
				"clientscripts\\mp\\mp_raid.csc",
				"clientscripts\\mp\\mp_raid.gsc",
				"clientscripts\\mp\\mp_uplink.csc",
				"clientscripts\\mp\\mp_uplink.gsc",
				"clientscripts\\mp\\zm_prison.gsc",
				"clientscripts\\mp\\zombies\\_callbacks.csc",
				"clientscripts\\mp\\zombies\\_callbacks.gsc",
				"clientscripts\\mp\\zombies\\_clientfaceanim_zm.csc",
				"clientscripts\\mp\\zombies\\_clientfaceanim_zm.gsc",
				"clientscripts\\mp\\zombies\\_face_utility_zm.csc",
				"clientscripts\\mp\\zombies\\_face_utility_zm.gsc",
				"clientscripts\\mp\\zombies\\_load.csc",
				"clientscripts\\mp\\zombies\\_load.gsc",
				"clientscripts\\mp\\zombies\\_players.csc",
				"clientscripts\\mp\\zombies\\_players.gsc",
				"clientscripts\\mp\\zombies\\_zm.csc",
				"clientscripts\\mp\\zombies\\_zm.gsc",
				"clientscripts\\mp\\zombies\\_zm_audio.csc",
				"clientscripts\\mp\\zombies\\_zm_audio.gsc",
				"clientscripts\\mp\\zombies\\_zm_buildables.csc",
				"clientscripts\\mp\\zombies\\_zm_buildables.gsc",
				"clientscripts\\mp\\zombies\\_zm_clone.csc",
				"clientscripts\\mp\\zombies\\_zm_clone.gsc",
				"clientscripts\\mp\\zombies\\_zm_equip_gasmask.csc",
				"clientscripts\\mp\\zombies\\_zm_equip_gasmask.gsc",
				"clientscripts\\mp\\zombies\\_zm_equip_hacker.csc",
				"clientscripts\\mp\\zombies\\_zm_equip_hacker.gsc",
				"clientscripts\\mp\\zombies\\_zm_equipment.csc",
				"clientscripts\\mp\\zombies\\_zm_equipment.gsc",
				"clientscripts\\mp\\zombies\\_zm_ffotd.csc",
				"clientscripts\\mp\\zombies\\_zm_ffotd.gsc",
				"clientscripts\\mp\\zombies\\_zm_gump.csc",
				"clientscripts\\mp\\zombies\\_zm_gump.gsc",
				"clientscripts\\mp\\zombies\\_zm_magicbox.csc",
				"clientscripts\\mp\\zombies\\_zm_magicbox.gsc",
				"clientscripts\\mp\\zombies\\_zm_perks.csc",
				"clientscripts\\mp\\zombies\\_zm_perks.gsc",
				"clientscripts\\mp\\zombies\\_zm_powerups.csc",
				"clientscripts\\mp\\zombies\\_zm_powerups.gsc",
				"clientscripts\\mp\\zombies\\_zm_score.csc",
				"clientscripts\\mp\\zombies\\_zm_score.gsc",
				"clientscripts\\mp\\zombies\\_zm_traps.csc",
				"clientscripts\\mp\\zombies\\_zm_traps.gsc",
				"clientscripts\\mp\\zombies\\_zm_utility.csc",
				"clientscripts\\mp\\zombies\\_zm_utility.gsc",
				"clientscripts\\mp\\zombies\\_zm_weap_cymbal_monkey.csc",
				"clientscripts\\mp\\zombies\\_zm_weap_cymbal_monkey.gsc",
				"clientscripts\\mp\\zombies\\_zm_weap_thundergun.csc",
				"clientscripts\\mp\\zombies\\_zm_weap_thundergun.gsc",
				"clientscripts\\mp\\zombies\\_zm_weapons.csc",
				"clientscripts\\mp\\zombies\\_zm_weapons.gsc",
				"codescripts\\character.gsc",
				"codescripts\\character_mp.gsc",
				"codescripts\\delete.csc",
				"codescripts\\delete.gsc",
				"codescripts\\struct.csc",
				"codescripts\\struct.gsc",
				"common_scripts\\utility.gsc",
				"maps\\mp\\_acousticsensor.gsc",
				"maps\\mp\\_ambientpackage.gsc",
				"maps\\mp\\_art.gsc",
				"maps\\mp\\_audio.gsc",
				"maps\\mp\\_ballistic_knife.gsc",
				"maps\\mp\\_bb.gsc",
				"maps\\mp\\_bouncingbetty.gsc",
				"maps\\mp\\_burnplayer.gsc",
				"maps\\mp\\_busing.gsc",
				"maps\\mp\\_challenges.gsc",
				"maps\\mp\\_compass.gsc",
				"maps\\mp\\_createfx.gsc",
				"maps\\mp\\_createfxmenu.gsc",
				"maps\\mp\\_createfxundo.gsc",
				"maps\\mp\\_decoy.gsc",
				"maps\\mp\\_demo.gsc",
				"maps\\mp\\_destructible.gsc",
				"maps\\mp\\_development_dvars.gsc",
				"maps\\mp\\_empgrenade.gsc",
				"maps\\mp\\_entityheadicons.gsc",
				"maps\\mp\\_events.gsc",
				"maps\\mp\\_explosive_bolt.gsc",
				"maps\\mp\\_flashgrenades.gsc",
				"maps\\mp\\_fx.gsc",
				"maps\\mp\\_fxanim.gsc",
				"maps\\mp\\_gameadvertisement.gsc",
				"maps\\mp\\_gamerep.gsc",
				"maps\\mp\\_global_fx.gsc",
				"maps\\mp\\_hacker_tool.gsc",
				"maps\\mp\\_heatseekingmissile.gsc",
				"maps\\mp\\_interactive_objects.gsc",
				"maps\\mp\\_load.gsc",
				"maps\\mp\\_medals.gsc",
				"maps\\mp\\_menus.gsc",
				"maps\\mp\\_mgturret.gsc",
				"maps\\mp\\_multi_extracam.gsc",
				"maps\\mp\\_music.gsc",
				"maps\\mp\\_pc.gsc",
				"maps\\mp\\_popups.gsc",
				"maps\\mp\\_proximity_grenade.gsc",
				"maps\\mp\\_riotshield.gsc",
				"maps\\mp\\_satchel_charge.gsc",
				"maps\\mp\\_scoreevents.gsc",
				"maps\\mp\\_scoreevents.gsct",
				"maps\\mp\\_scrambler.gsc",
				"maps\\mp\\_script_gen.gsc",
				"maps\\mp\\_sensor_grenade.gsc",
				"maps\\mp\\_serverfaceanim_mp.gsc",
				"maps\\mp\\_smokegrenade.gsc",
				"maps\\mp\\_sticky_grenade.gsc",
				"maps\\mp\\_tabun.gsc",
				"maps\\mp\\_tacticalinsertion.gsc",
				"maps\\mp\\_teargrenades.gsc",
				"maps\\mp\\_treadfx.gsc",
				"maps\\mp\\_trophy_system.gsc",
				"maps\\mp\\_utility.gsc",
				"maps\\mp\\_vehicles.gsc",
				"maps\\mp\\_visionset_mgr.gsc",
				"maps\\mp\\animscripts\\dog_combat.gsc",
				"maps\\mp\\animscripts\\dog_death.gsc",
				"maps\\mp\\animscripts\\dog_flashed.gsc",
				"maps\\mp\\animscripts\\dog_init.gsc",
				"maps\\mp\\animscripts\\dog_jump.gsc",
				"maps\\mp\\animscripts\\dog_move.gsc",
				"maps\\mp\\animscripts\\dog_pain.gsc",
				"maps\\mp\\animscripts\\dog_stop.gsc",
				"maps\\mp\\animscripts\\dog_turn.gsc",
				"maps\\mp\\animscripts\\shared.gsc",
				"maps\\mp\\animscripts\\traverse\\jump_down_40.gsc",
				"maps\\mp\\animscripts\\traverse\\jump_down_56.gsc",
				"maps\\mp\\animscripts\\traverse\\jump_down_96.gsc",
				"maps\\mp\\animscripts\\traverse\\mantle_on_40.gsc",
				"maps\\mp\\animscripts\\traverse\\mantle_on_56.gsc",
				"maps\\mp\\animscripts\\traverse\\mantle_on_80.gsc",
				"maps\\mp\\animscripts\\traverse\\mantle_on_96.gsc",
				"maps\\mp\\animscripts\\traverse\\mantle_over_40.gsc",
				"maps\\mp\\animscripts\\traverse\\mantle_window_36.gsc",
				"maps\\mp\\animscripts\\traverse\\shared.gsc",
				"maps\\mp\\animscripts\\traverse\\through_hole_42.gsc",
				"maps\\mp\\animscripts\\traverse\\zm_mantle_over_40.gsc",
				"maps\\mp\\animscripts\\traverse\\zm_shared.gsc",
				"maps\\mp\\animscripts\\utility.gsc",
				"maps\\mp\\animscripts\\zm_combat.gsc",
				"maps\\mp\\animscripts\\zm_death.gsc",
				"maps\\mp\\animscripts\\zm_dog_combat.gsc",
				"maps\\mp\\animscripts\\zm_dog_death.gsc",
				"maps\\mp\\animscripts\\zm_dog_flashed.gsc",
				"maps\\mp\\animscripts\\zm_dog_init.gsc",
				"maps\\mp\\animscripts\\zm_dog_jump.gsc",
				"maps\\mp\\animscripts\\zm_dog_move.gsc",
				"maps\\mp\\animscripts\\zm_dog_pain.gsc",
				"maps\\mp\\animscripts\\zm_dog_stop.gsc",
				"maps\\mp\\animscripts\\zm_dog_turn.gsc",
				"maps\\mp\\animscripts\\zm_flashed.gsc",
				"maps\\mp\\animscripts\\zm_init.gsc",
				"maps\\mp\\animscripts\\zm_jump.gsc",
				"maps\\mp\\animscripts\\zm_melee.gsc",
				"maps\\mp\\animscripts\\zm_move.gsc",
				"maps\\mp\\animscripts\\zm_pain.gsc",
				"maps\\mp\\animscripts\\zm_run.gsc",
				"maps\\mp\\animscripts\\zm_scripted.gsc",
				"maps\\mp\\animscripts\\zm_shared.gsc",
				"maps\\mp\\animscripts\\zm_stop.gsc",
				"maps\\mp\\animscripts\\zm_turn.gsc",
				"maps\\mp\\animscripts\\zm_utility.gsc",
				"maps\\mp\\bots\\_bot.gsc",
				"maps\\mp\\bots\\_bot_combat.gsc",
				"maps\\mp\\bots\\_bot_conf.gsc",
				"maps\\mp\\bots\\_bot_ctf.gsc",
				"maps\\mp\\bots\\_bot_dem.gsc",
				"maps\\mp\\bots\\_bot_dom.gsc",
				"maps\\mp\\bots\\_bot_hack.gsc",
				"maps\\mp\\bots\\_bot_hq.gsc",
				"maps\\mp\\bots\\_bot_koth.gsc",
				"maps\\mp\\bots\\_bot_loadout.gsc",
				"maps\\mp\\bots\\_bot_sd.gsc",
				"maps\\mp\\createart\\mp_nuketown_2020_art.gsc",
				"maps\\mp\\createfx\\mp_nuketown_2020_fx.gsc",
				"maps\\mp\\gametypes\\_battlechatter_mp.gsc",
				"maps\\mp\\gametypes\\_callbacksetup.gsc",
				"maps\\mp\\gametypes\\_class.gsc",
				"maps\\mp\\gametypes\\_clientids.gsc",
				"maps\\mp\\gametypes\\_copter.gsc",
				"maps\\mp\\gametypes\\_damagefeedback.gsc",
				"maps\\mp\\gametypes\\_deathicons.gsc",
				"maps\\mp\\gametypes\\_dev.gsc",
				"maps\\mp\\gametypes\\_dev_class.gsc",
				"maps\\mp\\gametypes\\_friendicons.gsc",
				"maps\\mp\\gametypes\\_gameobjects.gsc",
				"maps\\mp\\gametypes\\_globalentities.gsc",
				"maps\\mp\\gametypes\\_globallogic.gsc",
				"maps\\mp\\gametypes\\_globallogic_actor.gsc",
				"maps\\mp\\gametypes\\_globallogic_audio.gsc",
				"maps\\mp\\gametypes\\_globallogic_defaults.gsc",
				"maps\\mp\\gametypes\\_globallogic_player.gsc",
				"maps\\mp\\gametypes\\_globallogic_score.gsc",
				"maps\\mp\\gametypes\\_globallogic_spawn.gsc",
				"maps\\mp\\gametypes\\_globallogic_ui.gsc",
				"maps\\mp\\gametypes\\_globallogic_utils.gsc",
				"maps\\mp\\gametypes\\_globallogic_vehicle.gsc",
				"maps\\mp\\gametypes\\_healthoverlay.gsc",
				"maps\\mp\\gametypes\\_hostmigration.gsc",
				"maps\\mp\\gametypes\\_hud.gsc",
				"maps\\mp\\gametypes\\_hud_message.gsc",
				"maps\\mp\\gametypes\\_hud_util.gsc",
				"maps\\mp\\gametypes\\_killcam.gsc",
				"maps\\mp\\gametypes\\_menus.gsc",
				"maps\\mp\\gametypes\\_objpoints.gsc",
				"maps\\mp\\gametypes\\_perplayer.gsc",
				"maps\\mp\\gametypes\\_persistence.gsc",
				"maps\\mp\\gametypes\\_pregame.gsc",
				"maps\\mp\\gametypes\\_rank.gsc",
				"maps\\mp\\gametypes\\_scoreboard.gsc",
				"maps\\mp\\gametypes\\_serversettings.gsc",
				"maps\\mp\\gametypes\\_shellshock.gsc",
				"maps\\mp\\gametypes\\_spawning.gsc",
				"maps\\mp\\gametypes\\_spawnlogic.gsc",
				"maps\\mp\\gametypes\\_spectating.gsc",
				"maps\\mp\\gametypes\\_tweakables.gsc",
				"maps\\mp\\gametypes\\_wager.gsc",
				"maps\\mp\\gametypes\\_weapon_utils.gsc",
				"maps\\mp\\gametypes\\_weaponobjects.gsc",
				"maps\\mp\\gametypes\\_weapons.gsc",
				"maps\\mp\\gametypes\\conf.gsc",
				"maps\\mp\\gametypes\\ctf.gsc",
				"maps\\mp\\gametypes\\dem.gsc",
				"maps\\mp\\gametypes\\dm.gsc",
				"maps\\mp\\gametypes\\dom.gsc",
				"maps\\mp\\gametypes\\gun.gsc",
				"maps\\mp\\gametypes\\hq.gsc",
				"maps\\mp\\gametypes\\koth.gsc",
				"maps\\mp\\gametypes\\oic.gsc",
				"maps\\mp\\gametypes\\oneflag.gsc",
				"maps\\mp\\gametypes\\sas.gsc",
				"maps\\mp\\gametypes\\sd.gsc",
				"maps\\mp\\gametypes\\shrp.gsc",
				"maps\\mp\\gametypes\\tdm.gsc",
				"maps\\mp\\gametypes_zm\\_callbacksetup.gsc",
				"maps\\mp\\gametypes_zm\\_clientids.gsc",
				"maps\\mp\\gametypes_zm\\_damagefeedback.gsc",
				"maps\\mp\\gametypes_zm\\_dev.gsc",
				"maps\\mp\\gametypes_zm\\_gameobjects.gsc",
				"maps\\mp\\gametypes_zm\\_globalentities.gsc",
				"maps\\mp\\gametypes_zm\\_globallogic.gsc",
				"maps\\mp\\gametypes_zm\\_globallogic_actor.gsc",
				"maps\\mp\\gametypes_zm\\_globallogic_audio.gsc",
				"maps\\mp\\gametypes_zm\\_globallogic_defaults.gsc",
				"maps\\mp\\gametypes_zm\\_globallogic_player.gsc",
				"maps\\mp\\gametypes_zm\\_globallogic_score.gsc",
				"maps\\mp\\gametypes_zm\\_globallogic_spawn.gsc",
				"maps\\mp\\gametypes_zm\\_globallogic_ui.gsc",
				"maps\\mp\\gametypes_zm\\_globallogic_utils.gsc",
				"maps\\mp\\gametypes_zm\\_globallogic_vehicle.gsc",
				"maps\\mp\\gametypes_zm\\_gv_actions.gsc",
				"maps\\mp\\gametypes_zm\\_healthoverlay.gsc",
				"maps\\mp\\gametypes_zm\\_hostmigration.gsc",
				"maps\\mp\\gametypes_zm\\_hud.gsc",
				"maps\\mp\\gametypes_zm\\_hud_message.gsc",
				"maps\\mp\\gametypes_zm\\_hud_util.gsc",
				"maps\\mp\\gametypes_zm\\_menus.gsc",
				"maps\\mp\\gametypes_zm\\_perplayer.gsc",
				"maps\\mp\\gametypes_zm\\_scoreboard.gsc",
				"maps\\mp\\gametypes_zm\\_serversettings.gsc",
				"maps\\mp\\gametypes_zm\\_shellshock.gsc",
				"maps\\mp\\gametypes_zm\\_spawning.gsc",
				"maps\\mp\\gametypes_zm\\_spawnlogic.gsc",
				"maps\\mp\\gametypes_zm\\_spectating.gsc",
				"maps\\mp\\gametypes_zm\\_tweakables.gsc",
				"maps\\mp\\gametypes_zm\\_weapon_utils.gsc",
				"maps\\mp\\gametypes_zm\\_weaponobjects.gsc",
				"maps\\mp\\gametypes_zm\\_weapons.gsc",
				"maps\\mp\\gametypes_zm\\_zm_gametype.gsc",
				"maps\\mp\\gametypes_zm\\zclassic.gsc",
				"maps\\mp\\killstreaks\\_ai_tank.gsc",
				"maps\\mp\\killstreaks\\_airsupport.gsc",
				"maps\\mp\\killstreaks\\_dogs.gsc",
				"maps\\mp\\killstreaks\\_emp.gsc",
				"maps\\mp\\killstreaks\\_helicopter.gsc",
				"maps\\mp\\killstreaks\\_helicopter_guard.gsc",
				"maps\\mp\\killstreaks\\_helicopter_gunner.gsc",
				"maps\\mp\\killstreaks\\_killstreak_weapons.gsc",
				"maps\\mp\\killstreaks\\_killstreakrules.gsc",
				"maps\\mp\\killstreaks\\_killstreaks.gsc",
				"maps\\mp\\killstreaks\\_missile_drone.gsc",
				"maps\\mp\\killstreaks\\_missile_swarm.gsc",
				"maps\\mp\\killstreaks\\_planemortar.gsc",
				"maps\\mp\\killstreaks\\_qrdrone.gsc",
				"maps\\mp\\killstreaks\\_radar.gsc",
				"maps\\mp\\killstreaks\\_rcbomb.gsc",
				"maps\\mp\\killstreaks\\_remote_weapons.gsc",
				"maps\\mp\\killstreaks\\_remotemissile.gsc",
				"maps\\mp\\killstreaks\\_remotemortar.gsc",
				"maps\\mp\\killstreaks\\_spyplane.gsc",
				"maps\\mp\\killstreaks\\_straferun.gsc",
				"maps\\mp\\killstreaks\\_supplycrate.gsc",
				"maps\\mp\\killstreaks\\_supplydrop.gsc",
				"maps\\mp\\killstreaks\\_turret_killstreak.gsc",
				"maps\\mp\\mp_bridge.gsc",
				"maps\\mp\\mp_carrier.gsc",
				"maps\\mp\\mp_castaway.gsc",
				"maps\\mp\\mp_concert.gsc",
				"maps\\mp\\mp_dig.gsc",
				"maps\\mp\\mp_dockside.gsc",
				"maps\\mp\\mp_dockside_crane.gsc",
				"maps\\mp\\mp_downhill.gsc",
				"maps\\mp\\mp_downhill_cablecar.gsc",
				"maps\\mp\\mp_drone.gsc",
				"maps\\mp\\mp_express.gsc",
				"maps\\mp\\mp_express_train.gsc",
				"maps\\mp\\mp_frostbite.gsc",
				"maps\\mp\\mp_hijacked.gsc",
				"maps\\mp\\mp_hydro.gsc",
				"maps\\mp\\mp_la.gsc",
				"maps\\mp\\mp_magma.gsc",
				"maps\\mp\\mp_meltdown.gsc",
				"maps\\mp\\mp_mirage.gsc",
				"maps\\mp\\mp_nightclub.gsc",
				"maps\\mp\\mp_nuketown_2020.gsc",
				"maps\\mp\\mp_nuketown_2020_amb.gsc",
				"maps\\mp\\mp_nuketown_2020_fx.gsc",
				"maps\\mp\\mp_overflow.gsc",
				"maps\\mp\\mp_paintball.gsc",
				"maps\\mp\\mp_pod.gsc",
				"maps\\mp\\mp_raid.gsc",
				"maps\\mp\\mp_skate.gsc",
				"maps\\mp\\mp_slums.gsc",
				"maps\\mp\\mp_socotra.gsc",
				"maps\\mp\\mp_studio.gsc",
				"maps\\mp\\mp_takeoff.gsc",
				"maps\\mp\\mp_turbine.gsc",
				"maps\\mp\\mp_uplink.gsc",
				"maps\\mp\\mp_vertigo.gsc",
				"maps\\mp\\mp_village.gsc",
				"maps\\mp\\teams\\_teams.gsc",
				"maps\\mp\\teams\\_teamset.gsc",
				"maps\\mp\\teams\\_teamset_multiteam.gsc",
				"maps\\mp\\teams\\_teamset_pmc.gsc",
				"maps\\mp\\teams\\_teamset_seals.gsc",
				"maps\\mp\\zm_tomb_craftables.gsc",
				"maps\\mp\\zm_tomb_distance_tracking.gsc",
				"maps\\mp\\zm_tomb_ffotd.gsc",
				"maps\\mp\\zm_tomb_tank.gsc",
				"maps\\mp\\zombies\\_load.gsc",
				"maps\\mp\\zombies\\_zm.gsc",
				"maps\\mp\\zombies\\_zm_ai_basic.gsc",
				"maps\\mp\\zombies\\_zm_ai_dogs.gsc",
				"maps\\mp\\zombies\\_zm_ai_faller.gsc",
				"maps\\mp\\zombies\\_zm_ai_mechz_ffotd.gsc",
				"maps\\mp\\zombies\\_zm_audio.gsc",
				"maps\\mp\\zombies\\_zm_audio_announcer.gsc",
				"maps\\mp\\zombies\\_zm_blockers.gsc",
				"maps\\mp\\zombies\\_zm_bot.gsc",
				"maps\\mp\\zombies\\_zm_buildables.gsc",
				"maps\\mp\\zombies\\_zm_chugabud.gsc",
				"maps\\mp\\zombies\\_zm_clone.gsc",
				"maps\\mp\\zombies\\_zm_devgui.gsc",
				"maps\\mp\\zombies\\_zm_equip_gasmask.gsc",
				"maps\\mp\\zombies\\_zm_equip_hacker.gsc",
				"maps\\mp\\zombies\\_zm_equip_turbine.gsc",
				"maps\\mp\\zombies\\_zm_equipment.gsc",
				"maps\\mp\\zombies\\_zm_ffotd.gsc",
				"maps\\mp\\zombies\\_zm_game_module.gsc",
				"maps\\mp\\zombies\\_zm_gump.gsc",
				"maps\\mp\\zombies\\_zm_hackables_boards.gsc",
				"maps\\mp\\zombies\\_zm_hackables_box.gsc",
				"maps\\mp\\zombies\\_zm_hackables_doors.gsc",
				"maps\\mp\\zombies\\_zm_hackables_packapunch.gsc",
				"maps\\mp\\zombies\\_zm_hackables_perks.gsc",
				"maps\\mp\\zombies\\_zm_hackables_powerups.gsc",
				"maps\\mp\\zombies\\_zm_hackables_wallbuys.gsc",
				"maps\\mp\\zombies\\_zm_jump_pad.gsc",
				"maps\\mp\\zombies\\_zm_laststand.gsc",
				"maps\\mp\\zombies\\_zm_magicbox.gsc",
				"maps\\mp\\zombies\\_zm_magicbox_lock.gsc",
				"maps\\mp\\zombies\\_zm_mgturret.gsc",
				"maps\\mp\\zombies\\_zm_net.gsc",
				"maps\\mp\\zombies\\_zm_perk_electric_cherry.gsc",
				"maps\\mp\\zombies\\_zm_perks.gsc",
				"maps\\mp\\zombies\\_zm_pers_upgrades.gsc",
				"maps\\mp\\zombies\\_zm_pers_upgrades_functions.gsc",
				"maps\\mp\\zombies\\_zm_pers_upgrades_system.gsc",
				"maps\\mp\\zombies\\_zm_playerhealth.gsc",
				"maps\\mp\\zombies\\_zm_power.gsc",
				"maps\\mp\\zombies\\_zm_powerups.gsc",
				"maps\\mp\\zombies\\_zm_score.gsc",
				"maps\\mp\\zombies\\_zm_server_throttle.gsc",
				"maps\\mp\\zombies\\_zm_sidequests.gsc",
				"maps\\mp\\zombies\\_zm_spawner.gsc",
				"maps\\mp\\zombies\\_zm_stats.gsc",
				"maps\\mp\\zombies\\_zm_timer.gsc",
				"maps\\mp\\zombies\\_zm_tombstone.gsc",
				"maps\\mp\\zombies\\_zm_traps.gsc",
				"maps\\mp\\zombies\\_zm_turned.gsc",
				"maps\\mp\\zombies\\_zm_unitrigger.gsc",
				"maps\\mp\\zombies\\_zm_utility.gsc",
				"maps\\mp\\zombies\\_zm_weap_cymbal_monkey.gsc",
				"maps\\mp\\zombies\\_zm_weap_thundergun.gsc",
				"maps\\mp\\zombies\\_zm_weapons.gsc",
				"maps\\mp\\zombies\\_zm_zonemgr.gsc",
				"mpbody\\class_assault_rus_pmc.gsc",
				"mpbody\\class_assault_usa_seals.gsc",
				"mpbody\\class_lmg_rus_pmc.gsc",
				"mpbody\\class_lmg_usa_seals.gsc",
				"mpbody\\class_shotgun_rus_pmc.gsc",
				"mpbody\\class_shotgun_usa_seals.gsc",
				"mpbody\\class_smg_rus_pmc.gsc",
				"mpbody\\class_smg_usa_seals.gsc",
				"mpbody\\class_sniper_usa_seals.gsc"
			};
			this.ScriptPath.Properties.Items.AddRange(items);
			this.ScriptPath.Properties.Sorted = true;
			this.ScriptPath.Properties.TextEditStyle = global::DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			global::System.Drawing.Size size2 = new global::System.Drawing.Size(0x115, 0x14);
			this.ScriptPath.Size = size2;
			this.ScriptPath.TabIndex = 6;
			global::System.Drawing.Point location3 = new global::System.Drawing.Point(0xB4, 0x16C);
			this.CreatorName.Location = location3;
			this.CreatorName.Name = "CreatorName";
			global::System.Drawing.Size size3 = new global::System.Drawing.Size(0x115, 0x14);
			this.CreatorName.Size = size3;
			this.CreatorName.TabIndex = 7;
			this.labelControl2.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location4 = new global::System.Drawing.Point(0xC, 0x16D);
			this.labelControl2.Location = location4;
			this.labelControl2.Name = "labelControl2";
			global::System.Drawing.Size size4 = new global::System.Drawing.Size(0x55, 0x10);
			this.labelControl2.Size = size4;
			this.labelControl2.TabIndex = 8;
			this.labelControl2.Text = "Creator Name:";
			this.labelControl3.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location5 = new global::System.Drawing.Point(0xC, 0x187);
			this.labelControl3.Location = location5;
			this.labelControl3.Name = "labelControl3";
			global::System.Drawing.Size size5 = new global::System.Drawing.Size(0x64, 0x10);
			this.labelControl3.Size = size5;
			this.labelControl3.TabIndex = 0xA;
			this.labelControl3.Text = "Naming Conflicts:";
			this.ConflictsHandling.EditValue = "Overwrite Existing GSX Projects";
			global::System.Drawing.Point location6 = new global::System.Drawing.Point(0xB4, 0x186);
			this.ConflictsHandling.Location = location6;
			this.ConflictsHandling.Name = "ConflictsHandling";
			global::DevExpress.XtraEditors.Controls.EditorButton[] buttons2 = new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton() { Kind = global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo }
			};
			this.ConflictsHandling.Properties.Buttons.AddRange(buttons2);
			object[] items2 = new object[]
			{
				"Overwrite Existing GSX Projects",
				"Ignore Projects with Same Name"
			};
			this.ConflictsHandling.Properties.Items.AddRange(items2);
			this.ConflictsHandling.Properties.TextEditStyle = global::DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			global::System.Drawing.Size size6 = new global::System.Drawing.Size(0x115, 0x14);
			this.ConflictsHandling.Size = size6;
			this.ConflictsHandling.TabIndex = 0xB;
			global::DevExpress.XtraTreeList.Columns.TreeListColumn[] columns = new global::DevExpress.XtraTreeList.Columns.TreeListColumn[]
			{
				this.treeListColumn1
			};
			this.ProjectsList.Columns.AddRange(columns);
			global::System.Drawing.Point location7 = new global::System.Drawing.Point(0xC, 0xC);
			this.ProjectsList.Location = location7;
			this.ProjectsList.Name = "ProjectsList";
			this.ProjectsList.OptionsBehavior.Editable = false;
			this.ProjectsList.OptionsBehavior.ImmediateEditor = false;
			this.ProjectsList.OptionsBehavior.KeepSelectedOnClick = false;
			this.ProjectsList.OptionsCustomization.AllowBandMoving = false;
			this.ProjectsList.OptionsCustomization.AllowColumnMoving = false;
			this.ProjectsList.OptionsCustomization.AllowQuickHideColumns = false;
			this.ProjectsList.OptionsCustomization.ShowBandsInCustomizationForm = false;
			this.ProjectsList.OptionsLayout.AddNewColumns = false;
			this.ProjectsList.OptionsMenu.EnableColumnMenu = false;
			this.ProjectsList.OptionsMenu.EnableFooterMenu = false;
			this.ProjectsList.OptionsMenu.ShowAutoFilterRowItem = false;
			this.ProjectsList.OptionsSelection.SelectNodesOnRightClick = true;
			global::System.Drawing.Size size7 = new global::System.Drawing.Size(0x2CF, 0x140);
			this.ProjectsList.Size = size7;
			this.ProjectsList.TabIndex = 0xC;
			this.treeListColumn1.Caption = "Project Name";
			this.treeListColumn1.FieldName = "Project Name";
			this.treeListColumn1.MinWidth = 0x22;
			this.treeListColumn1.Name = "treeListColumn1";
			this.treeListColumn1.Visible = true;
			this.treeListColumn1.VisibleIndex = 0;
			global::System.Drawing.Point location8 = new global::System.Drawing.Point(0xC, 0x1A9);
			this.progressBarControl1.Location = location8;
			this.progressBarControl1.Name = "progressBarControl1";
			this.progressBarControl1.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
			this.progressBarControl1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
			this.progressBarControl1.Properties.Step = 1;
			this.progressBarControl1.ShowProgressInTaskBar = true;
			global::System.Drawing.Size size8 = new global::System.Drawing.Size(0x2CF, 0x12);
			this.progressBarControl1.Size = size8;
			this.progressBarControl1.TabIndex = 0xD;
			this.StartImports.Enabled = false;
			global::System.Drawing.Point location9 = new global::System.Drawing.Point(0x1CF, 0x17D);
			this.StartImports.Location = location9;
			this.StartImports.Name = "StartImports";
			global::System.Drawing.Size size9 = new global::System.Drawing.Size(0x83, 0x26);
			this.StartImports.Size = size9;
			this.StartImports.TabIndex = 0xE;
			this.StartImports.Text = "Start Import";
			this.StartImports.Click += new global::System.EventHandler(this.StartImports_Click);
			global::System.Drawing.Point location10 = new global::System.Drawing.Point(0x258, 0x151);
			this.AddProjects.Location = location10;
			this.AddProjects.Name = "AddProjects";
			global::System.Drawing.Size size10 = new global::System.Drawing.Size(0x83, 0x26);
			this.AddProjects.Size = size10;
			this.AddProjects.TabIndex = 0xF;
			this.AddProjects.Text = "Add Projects Folder";
			this.AddProjects.Click += new global::System.EventHandler(this.AddProjects_Click);
			this.CancelImports.Enabled = false;
			global::System.Drawing.Point location11 = new global::System.Drawing.Point(0x258, 0x17D);
			this.CancelImports.Location = location11;
			this.CancelImports.Name = "CancelImports";
			global::System.Drawing.Size size11 = new global::System.Drawing.Size(0x83, 0x26);
			this.CancelImports.Size = size11;
			this.CancelImports.TabIndex = 0x10;
			this.CancelImports.Text = "Cancel";
			this.CancelImports.Visible = false;
			this.CancelImports.Click += new global::System.EventHandler(this.CancelImports_Click);
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			global::DevExpress.XtraBars.BarItem[] items3 = new global::DevExpress.XtraBars.BarItem[]
			{
				this.barButtonItem1,
				this.barButtonItem2,
				this.barButtonItem3
			};
			this.barManager1.Items.AddRange(items3);
			this.barManager1.MaxItemId = 3;
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = global::System.Windows.Forms.DockStyle.Top;
			global::System.Drawing.Point location12 = new global::System.Drawing.Point(0, 0);
			this.barDockControlTop.Location = location12;
			global::System.Drawing.Size size12 = new global::System.Drawing.Size(0x2EC, 0);
			this.barDockControlTop.Size = size12;
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Drawing.Point location13 = new global::System.Drawing.Point(0, 0x1C6);
			this.barDockControlBottom.Location = location13;
			global::System.Drawing.Size size13 = new global::System.Drawing.Size(0x2EC, 0);
			this.barDockControlBottom.Size = size13;
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = global::System.Windows.Forms.DockStyle.Left;
			global::System.Drawing.Point location14 = new global::System.Drawing.Point(0, 0);
			this.barDockControlLeft.Location = location14;
			global::System.Drawing.Size size14 = new global::System.Drawing.Size(0, 0x1C6);
			this.barDockControlLeft.Size = size14;
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = global::System.Windows.Forms.DockStyle.Right;
			global::System.Drawing.Point location15 = new global::System.Drawing.Point(0x2EC, 0);
			this.barDockControlRight.Location = location15;
			global::System.Drawing.Size size15 = new global::System.Drawing.Size(0, 0x1C6);
			this.barDockControlRight.Size = size15;
			this.barButtonItem1.Caption = "Remove Selected";
			this.barButtonItem1.Id = 0;
			this.barButtonItem1.Name = "barButtonItem1";
			this.barButtonItem1.ItemClick += new global::DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
			this.barButtonItem2.Caption = "Clear All";
			this.barButtonItem2.Id = 1;
			this.barButtonItem2.Name = "barButtonItem2";
			this.barButtonItem2.ItemClick += new global::DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
			this.barButtonItem3.Caption = "Add Projects";
			this.barButtonItem3.Id = 2;
			this.barButtonItem3.Name = "barButtonItem3";
			global::DevExpress.XtraBars.LinkPersistInfo[] links = new global::DevExpress.XtraBars.LinkPersistInfo[]
			{
				new global::DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
				new global::DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)
			};
			this.RContextMenu.LinksPersistInfo.AddRange(links);
			this.RContextMenu.Manager = this.barManager1;
			this.RContextMenu.Name = "RContextMenu";
			global::System.Drawing.Point location16 = new global::System.Drawing.Point(0x1CF, 0x152);
			this.simpleButton1.Location = location16;
			this.simpleButton1.Name = "simpleButton1";
			global::System.Drawing.Size size16 = new global::System.Drawing.Size(0x83, 0x25);
			this.simpleButton1.Size = size16;
			this.simpleButton1.TabIndex = 0x1A;
			this.simpleButton1.Text = "Add Project";
			this.simpleButton1.Click += new global::System.EventHandler(this.simpleButton1_Click);
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleDimensions = autoScaleDimensions;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			global::System.Drawing.Size clientSize = new global::System.Drawing.Size(0x2EC, 0x1C6);
			base.ClientSize = clientSize;
			base.Controls.Add(this.simpleButton1);
			base.Controls.Add(this.CancelImports);
			base.Controls.Add(this.AddProjects);
			base.Controls.Add(this.StartImports);
			base.Controls.Add(this.progressBarControl1);
			base.Controls.Add(this.ProjectsList);
			base.Controls.Add(this.ConflictsHandling);
			base.Controls.Add(this.labelControl3);
			base.Controls.Add(this.labelControl2);
			base.Controls.Add(this.CreatorName);
			base.Controls.Add(this.ScriptPath);
			base.Controls.Add(this.labelControl1);
			base.Controls.Add(this.barDockControlLeft);
			base.Controls.Add(this.barDockControlRight);
			base.Controls.Add(this.barDockControlBottom);
			base.Controls.Add(this.barDockControlTop);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
			base.LookAndFeel.UseDefaultLookAndFeel = false;
			base.Name = "ImportProjectDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Import Project";
			((global::System.ComponentModel.ISupportInitialize)this.ScriptPath.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CreatorName.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ConflictsHandling.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ProjectsList).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.progressBarControl1.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.barManager1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.RContextMenu).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool A_0)
		{
			if (A_0)
			{
				try
				{
					this.CleanupManaged();
					return;
				}
				finally
				{
					base.Dispose(true);
				}
			}
			base.Dispose(false);
		}

		private global::DevExpress.XtraEditors.LabelControl labelControl1;

		public global::DevExpress.XtraEditors.ComboBoxEdit ScriptPath;

		public global::DevExpress.XtraEditors.TextEdit CreatorName;

		private global::DevExpress.XtraEditors.LabelControl labelControl2;

		private global::DevExpress.XtraEditors.LabelControl labelControl3;

		private global::DevExpress.XtraEditors.ComboBoxEdit ConflictsHandling;

		private global::DevExpress.XtraTreeList.TreeList ProjectsList;

		private global::DevExpress.XtraEditors.ProgressBarControl progressBarControl1;

		private global::DevExpress.XtraEditors.SimpleButton StartImports;

		private global::DevExpress.XtraEditors.SimpleButton AddProjects;

		private global::DevExpress.XtraEditors.SimpleButton CancelImports;

		private global::DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;

		private global::DevExpress.XtraBars.BarManager barManager1;

		private global::DevExpress.XtraBars.BarDockControl barDockControlTop;

		private global::DevExpress.XtraBars.BarDockControl barDockControlBottom;

		private global::DevExpress.XtraBars.BarDockControl barDockControlLeft;

		private global::DevExpress.XtraBars.BarDockControl barDockControlRight;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem1;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem2;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem3;

		private global::DevExpress.XtraBars.PopupMenu RContextMenu;

		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		private global::System.ComponentModel.IContainer components;
	}
}
