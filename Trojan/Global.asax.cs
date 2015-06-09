﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using Trojan.Models;
using Trojan.Logic;

namespace Trojan
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Initialize the Attribute database.
            Database.SetInitializer(new AttributeDatabaseInitializer());

            // Create the custom role and user.
            RoleActions roleActions = new RoleActions();
            roleActions.AddUserAndRole();

            // Add Routes.
            RegisterCustomRoutes(RouteTable.Routes);
        }

        void RegisterCustomRoutes(RouteCollection routes)
        {
          routes.MapPageRoute(
              "AttributesByCategoryRoute",
              "Category/{categoryName}",
              "~/AttributeList.aspx"
          );
          routes.MapPageRoute(
              "AttributeByNameRoute",
              "Attribute/{attributeName}",
              "~/AttributeDetails.aspx"
          );
        }
    }
}