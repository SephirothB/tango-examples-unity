﻿/*
 * Copyright 2014 Google Inc. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using UnityEngine;
using System;
using Tango;

/// <summary>
/// Get Tango events from Tango Service and log on GUI.
/// </summary>
public class EventController : TangoEventListener {
    [HideInInspector]
    public string m_eventString;
    private TangoApplication m_tangoApplication;
    
    /// <summary>
    /// Initialize the controller.
    /// </summary>
    void Start ()
    {
        m_eventString = string.Empty;
        m_tangoApplication = FindObjectOfType<TangoApplication>();
    }
    
    /// <summary>
    /// Handle the callback sent by the Tango Service
    /// when a new Tango event is sampled.
    /// DO NOT USE THE UNITY API FROM INSIDE THIS FUNCTION!
    /// </summary>
    /// <param name="callbackContext">Callback context.</param>
    /// <param name="tangoEvent">Tango event.</param>
    protected override void _onEventAvailable(IntPtr callbackContext, TangoEvent tangoEvent)
    {
        m_eventString = tangoEvent.event_key + ": " + tangoEvent.event_value;
    }
}
