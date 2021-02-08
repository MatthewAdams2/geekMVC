using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private PlayerModel Model { get; set; }
    private PlayerView View { get; set; }

    public PlayerController (PlayerModel model, PlayerView view)
    {
        Model = model;
        View = view;
    }

    public void Update()
    {
        if (View.DamageProvider != null)
            Model.ReceiveDamage(View.DamageProvider.Damage);

        if (Model.IsHpChanged)
            View.SetHpNormalized(Model.NormalizedHp);
    }

    public void LateUpdate()
    {
        Model.LateUpdate();
        View.DoLateUpdate();
    }
}
