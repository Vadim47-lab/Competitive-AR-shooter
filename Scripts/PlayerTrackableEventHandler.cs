using UnityEngine;

public class PlayerTrackableEventHandler : DefaultTrackableEventHandler
{
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        Player player = GetComponentInChildren<Player>();
        if (player != null)
        {
            player.gameObject.SetActive(true);
        }
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        Player player = GetComponentInChildren<Player>();
        if (player != null)
        {
            player.gameObject.SetActive(false);
        }
    }
}