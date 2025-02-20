﻿
using ReactiveUI;
using System;
using System.Reactive;

namespace SocialNetwork.Client.ViewModels;

public class UserViewModel : ViewModelBase
{
	private int _id;

	public int Id 
	{
		get => _id;
		set => this.RaiseAndSetIfChanged(ref _id, value); 
	}

	private string _firstName = string.Empty;

	public string FirstName 
	{
		get => _firstName;
		set => this.RaiseAndSetIfChanged(ref _firstName, value);
	}

	private string _lastName = string.Empty;

	public string LastName 
	{
		get => _lastName;
		set => this.RaiseAndSetIfChanged(ref _lastName, value);
	}

	private string _patronymic = string.Empty;

	public string Patronymic 
	{
		get => _patronymic;
		set => this.RaiseAndSetIfChanged(ref _patronymic, value);
	}

	private string _gender = string.Empty;

	public string Gender 
	{
		get => _gender;
		set => this.RaiseAndSetIfChanged(ref _gender, value);
	}

	private DateTime? _birthDate;

	public DateTime? BirthDate 
	{
		get => _birthDate;
		set => this.RaiseAndSetIfChanged(ref _birthDate, value);
	}

	private DateTime? _registrationDate;

	public DateTime? RegistrationDate 
	{
		get => _registrationDate;
		set => this.RaiseAndSetIfChanged(ref _registrationDate, value);
	}

	public ReactiveCommand<Unit, UserViewModel> OnSubmitCommand { get; set; }

	public UserViewModel()
	{
		OnSubmitCommand = ReactiveCommand.Create(() => this);
	}
}
