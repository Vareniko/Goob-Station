// SPDX-FileCopyrightText: 2023 Leon Friedrich <60421075+ElectroJr@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 metalgearsloth <comedian_vs_clown@hotmail.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Chemistry.Components;
using Robust.Client.GameObjects;

namespace Content.Client.Chemistry.EntitySystems;

public sealed class PillSystem : EntitySystem
{
    [Dependency] private readonly SpriteSystem _sprite = default!;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<PillComponent, AfterAutoHandleStateEvent>(OnHandleState);
    }

    private void OnHandleState(EntityUid uid, PillComponent component, ref AfterAutoHandleStateEvent args)
    {
        if (!TryComp(uid, out SpriteComponent? sprite))
            return;

        if (!_sprite.TryGetLayer((uid, sprite), 0, out var layer, false))
            return;

        _sprite.LayerSetRsiState(layer, $"pill{component.PillType + 1}");
    }
}