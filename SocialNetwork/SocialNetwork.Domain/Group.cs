﻿using System;

/// <summary>
/// Группа.
/// </summary>
public class Group
{
	#region Свойства.
	/// <summary>
	/// Идентификатор.
	/// </summary>
	public int Id { get; set; }

	/// <summary>
	/// Название.
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// Описание.
	/// </summary>
	public string Description { get; set; }

	/// <summary>
	/// Дата создания.
	/// </summary>
	public DateTime CreationDate { get; set; }
	#endregion
}
