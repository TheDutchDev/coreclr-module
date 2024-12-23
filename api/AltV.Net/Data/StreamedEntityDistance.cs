using AltV.Net.Elements.Entities;

namespace AltV.Net.Data;

/// <summary>
/// Streamed entity
/// </summary>
/// <param name="Entity">The entity</param>
/// <param name="Distance">The distance between the player and this entity</param>
public record StreamedEntityDistance(IEntity Entity, int Distance);