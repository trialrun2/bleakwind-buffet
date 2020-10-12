/*
 * Author: Zane Myers
 * Class name: ChangeScreen.cs
 * Purpose: Class created to allow the WPF to switch between two different wpf's
 */
using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale
{
    public static class ChangeScreen
    {
        /// <summary>
        /// Finds the control passed to the function
        /// </summary>
        /// <typeparam name="T">some control</typeparam>
        /// <param name="element">The control we are looking for when found</param>
        /// <returns></returns>
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);
            
            if (parent == null) return null;
            if (parent is T) return parent as T;

            return parent.FindAncestor<T>();
        }
    }
}
