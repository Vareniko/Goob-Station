// SPDX-FileCopyrightText: 2024 Simon <63975668+Simyon264@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

public sealed partial class CCVars
{
    public static readonly CVarDef<bool> ViewportStretch =
        CVarDef.Create("viewport.stretch", true, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<int> ViewportFixedScaleFactor =
        CVarDef.Create("viewport.fixed_scale_factor", 2, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<int> ViewportSnapToleranceMargin =
        CVarDef.Create("viewport.snap_tolerance_margin", 64, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<int> ViewportSnapToleranceClip =
        CVarDef.Create("viewport.snap_tolerance_clip", 32, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<bool> ViewportScaleRender =
        CVarDef.Create("viewport.scale_render", true, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<int> ViewportMinimumWidth =
        CVarDef.Create("viewport.minimum_width", 15, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> ViewportMaximumWidth =
        CVarDef.Create("viewport.maximum_width", 21, CVar.REPLICATED | CVar.SERVER);

    public static readonly CVarDef<int> ViewportWidth =
        CVarDef.Create("viewport.width", 30, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<bool> ViewportVerticalFit =
        CVarDef.Create("viewport.vertical_fit", true, CVar.CLIENTONLY | CVar.ARCHIVE);
}