using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SimulaciaModelu : MonoBehaviour {


    public Slider posuvatko;
    public ParticleSystem Elektron;
    public ParticleSystem ProtonHore;
    public ParticleSystem ProtonDole;


	public void zmenavyzarovania()
    {
        var ElektronovaEmisia = Elektron.emission;
        var ProtonovaEmHore = ProtonHore.emission;
        var ProtonovaEmDole = ProtonDole.emission;

        ElektronovaEmisia.rateOverTime = posuvatko.value;
        ProtonovaEmDole.rateOverTime = posuvatko.value;
        ProtonovaEmHore.rateOverTime = posuvatko.value;
    }
}
