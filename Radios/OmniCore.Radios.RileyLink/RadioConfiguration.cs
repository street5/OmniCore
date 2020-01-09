﻿using System;
using System.Collections.Generic;
using System.Text;
using OmniCore.Model.Enumerations;
using OmniCore.Model.Interfaces.Common;

namespace OmniCore.Radios.RileyLink
{
    public class RadioConfiguration : IRadioConfiguration
    {
        public bool KeepConnected { get; set; } = true;

        public TimeSpan RadioResponseTimeout { get; set; } = TimeSpan.FromSeconds(20);
        public TimeSpan RadioResponseCooldown { get; set; } = TimeSpan.FromSeconds(5);

        public TimeSpan RadioConnectTimeout { get; set; } = TimeSpan.FromSeconds(20);
        public TimeSpan RadioConnectCooldown { get; set; } = TimeSpan.FromSeconds(5);

        public TimeSpan RadioDisconnectTimeout { get; set; } = TimeSpan.FromSeconds(5);

        public TimeSpan RadioDiscoveryTimeout { get; set; } = TimeSpan.FromSeconds(15);
        public TimeSpan RadioDiscoveryCooldown { get; set; } = TimeSpan.FromSeconds(45);

        public TimeSpan? RssiUpdateInterval { get; set; } = TimeSpan.FromMinutes(10);

        // shifts in complements of 326.211 Hz
        public int FrequencyShift { get; set; } = 0;

        public TransmissionPower Amplification { get; set; } = TransmissionPower.Normal;

        // 0x00 to 0x1F
        public int RxIntermediateFrequency { get; set; } = 0x06;

        // 0x00 to 0x07
        public int PqeThreshold { get; set; } = 0x01;

        // 0x00 to 0x03
        public int FilterBWExponent { get; set; } = 3;

        // 0x00 to 0x03
        public int FilterBWDecimationRatio { get; set; } = 0;

        public bool DataWhitening { get; set; } = false;

        public bool PreambleCheckWithCarrierSense { get; set; } = true;

        // 0x00 to 0x07
        public int TxPreambleCountSetting { get; set; } = 0x04;

        public bool ForwardErrorCorrection { get; set; } = false;

        // 0x00 to 0x03
        public int RxAttenuationLevel { get; set; } = 0x00;
    }
}
