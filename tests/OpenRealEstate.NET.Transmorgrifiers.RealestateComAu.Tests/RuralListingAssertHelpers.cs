﻿using OpenRealEstate.NET.Core.Rural;
using Shouldly;

namespace OpenRealEstate.NET.Transmorgrifiers.RealestateComAu.Tests
{
    public static class RuralListingAssertHelpers
    {
        public static void AssertRuralListing(RuralListing source,
                                              RuralListing destination)
        {
            ListingAssertHelpers.AssertCommonData(source, destination);
            BuildingDetailsAssertHelpers.AssertBuildingDetails(source.BuildingDetails, destination.BuildingDetails);

            source.AuctionOn.ShouldBe(destination.AuctionOn);
        }
    }
}