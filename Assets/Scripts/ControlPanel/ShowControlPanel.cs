using UnityEngine;

namespace Assets.Scripts.ControlPanel
{
    public class ShowControlPanel : MonoBehaviour
    {
        public GameObject cameraControlPanel;
        public GameObject controlPanel;
        public GameObject cameraAstronaut;
        public GameObject iSSSatelite;
        public GameObject spaceXSatellite;
        public GameObject pSSurface;
        public GameObject earth;
        public GameObject cameraIss;
        public GameObject cameraSpaceX;
        public GameObject sun;

        [SerializeField] KeyCode key;

        AudioListener cameraOneAudioLis;
        AudioListener cameraTwoAudioLis;

        void Start()
        {
            //Get Camera Listeners
            cameraOneAudioLis = cameraControlPanel.GetComponent<AudioListener>();
            cameraTwoAudioLis = cameraAstronaut.GetComponent<AudioListener>();

            //Camera Position Set
            cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
            ButtonSwitch();
        }

        void Update()
        {
            //Change Camera Keyboard
            switchCamera(key);
        }

        //Change Camera Keyboard
        public void switchCamera(KeyCode key)
        {
            if (Input.GetKeyDown(key))
            {
                cameraChangeCounter();
            }
        }

        //Button Click
        public void ButtonSwitch()
        {
            cameraChangeCounter();
        }

        //Camera Counter
        void cameraChangeCounter()
        {
            int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
            cameraPositionCounter++;
            cameraPositionChange(cameraPositionCounter);
        }

        //Camera change Logic
        void cameraPositionChange(int camPosition)
        {
            if (camPosition > 1)
            {
                camPosition = 0;
            }

            //Set camera position database
            PlayerPrefs.SetInt("CameraPosition", camPosition);

            //Set camera position 1
            if (camPosition == 0)
            {
                cameraControlPanel.SetActive(true);
                cameraOneAudioLis.enabled = true;
                controlPanel.SetActive(true);

                cameraTwoAudioLis.enabled = false;
                cameraSpaceX.SetActive(false);
                cameraIss.SetActive(false);
                cameraAstronaut.SetActive(false);
                GetDisabled();
            }

            //Set camera position 2
            if (camPosition == 1)
            {
                cameraAstronaut.SetActive(true);
                cameraTwoAudioLis.enabled = true;
                GetEnabled();
                
                cameraOneAudioLis.enabled = false;
                cameraControlPanel.SetActive(false);
                controlPanel.SetActive(false);
            }
        }

        private void GetEnabled()
        {
            pSSurface.SetActive(true);
            sun.SetActive(true);
            earth.SetActive(true);
            spaceXSatellite.SetActive(true);
            iSSSatelite.SetActive(true);
        }
        private void GetDisabled()
        {
            pSSurface.SetActive(false);
            sun.SetActive(false);
            earth.SetActive(false);
            spaceXSatellite.SetActive(false);
            iSSSatelite.SetActive(false);
        }
    }
}
