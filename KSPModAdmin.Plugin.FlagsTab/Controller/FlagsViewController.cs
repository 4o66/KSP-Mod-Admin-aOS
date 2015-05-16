﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using KSPModAdmin.Core;
using KSPModAdmin.Core.Controller;
using KSPModAdmin.Core.Utils;
using KSPModAdmin.Core.Utils.Localization;
using KSPModAdmin.Plugin.FlagsTab.Views;

namespace KSPModAdmin.Plugin.FlagsTab.Controller
{
    /// <summary>
    /// Controller class for the Translation view.
    /// </summary>
    public class FlagsViewController
    {
        /// <summary>
        /// Gets or sets the view of the controller.
        /// </summary>
        public static ucFlagsView View { get; protected set; }

        internal static void Initialize(ucFlagsView view)
        {
            View = view;

            EventDistributor.AsyncTaskStarted += AsyncTaskStarted;
            EventDistributor.AsyncTaskDone += AsyncTaskDone;

            // Add your stuff to initialize here.
        }

        #region EventDistributor callback functions.

        /// <summary>
        /// Callback function for the AsyncTaskStarted event.
        /// Should disable all controls of the BaseView.
        /// </summary>
        protected static void AsyncTaskStarted(object sender)
        {
            View.SetEnabledOfAllControls(true);
        }

        /// <summary>
        /// Callback function for the AsyncTaskDone event.
        /// Should enable all controls of the BaseView.
        /// </summary>
        protected static void AsyncTaskDone(object sender)
        {
            View.SetEnabledOfAllControls(false);
        }

        #endregion
    }
}
