using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.signal.impl;
using Views;
using Commands;
using Signals;
public class MainContext : MVCSContext
{
	private UIManager _uIManager;
	private SoundManager _soundManager;

	public MainContext(UIManager uIManager, SoundManager soundManager, MonoBehaviour context)
						:base(context, ContextStartupFlags.MANUAL_MAPPING |
										ContextStartupFlags.MANUAL_LAUNCH)
	{
		_uIManager = uIManager;
		_soundManager = soundManager;
	}

	public override void Launch()
	{
		base.Launch();
		Signal StartGameSignal = injectionBinder.GetInstance<StartSignal>();
		StartGameSignal.Dispatch();
	}
	protected override void addCoreComponents()
	{
		base.addCoreComponents();
		injectionBinder.Unbind<ICommandBinder>();
		injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
	}
	protected override void mapBindings()
	{
		base.mapBindings();
		CommandBinding();
		InjectionsBinding();
		ViewBinding();
	}
	private void CommandBinding()
	{
		commandBinder.Bind<StartSignal>().To<StartCommand>().Once();
		commandBinder.Bind<FindSignal>().To<FindCommand>();
		commandBinder.Bind<LostSignal>().To<LostCommand>();
		commandBinder.Bind<PhotoSignal>().To<PhotoCommand>();
		commandBinder.Bind<ShareSignal>().To<ShareCommand>();
		commandBinder.Bind<BackSignal>().To<BackCommand>();
		commandBinder.Bind<MenuSignal>().To<MenuCommand>();
		commandBinder.Bind<MenuMailSignal>().To<MenuMailCommand>();
		commandBinder.Bind<MenuSoundSignal>().To<MenuSoundCommand>();
		commandBinder.Bind<MenuInfoSignal>().To<MenuInfoCommand>();
		commandBinder.Bind<MenuHideSignal>().To<MenuHideCommand>();
		commandBinder.Bind<ActiveFigureSignal>().To<DeactivateFigureCommand>().To<ActiveFigureCommand>();
		commandBinder.Bind<DeactivateFigureSignal>().To<DeactivateFigureCommand>();
	}
	private void InjectionsBinding()
	{
		injectionBinder.Bind<GameSetting>().To<GameSetting>().ToSingleton();
		injectionBinder.Bind<UIManager>().To(_uIManager);
		injectionBinder.Bind<SoundManager>().To(_soundManager);
		injectionBinder.Bind<MailSender>().To<MailSender>().ToSingleton();
	}
	private void ViewBinding()
	{
		mediationBinder.Bind<MenuView>().To<MenuMediator>();
		mediationBinder.Bind<PhotoView>().To<PhotoMediator>();
		mediationBinder.Bind<SeekView>().To<SeekMediator>();
		mediationBinder.Bind<ShareView>().To<ShareMediator>();
		mediationBinder.Bind<TriggerHandlerView>().To<TriggerHandlerMediator>();
		mediationBinder.Bind<WolfView>().To<WolfMediator>();
	}
}
