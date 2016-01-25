﻿//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="WhenParsingnUnit2ResultsFileWithMissingTraits.cs" company="PicklesDoc">
//  Copyright 2011 Jeffrey Cameron
//  Copyright 2012-present PicklesDoc team and community contributors
//
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  </copyright>
//  --------------------------------------------------------------------------------------------------------------------

using System;

using NFluent;

using NUnit.Framework;

using PicklesDoc.Pickles.ObjectModel;
using PicklesDoc.Pickles.TestFrameworks.NUnit2;

namespace PicklesDoc.Pickles.TestFrameworks.UnitTests.NUnit2
{
    [TestFixture]
    public class WhenParsingnUnit2ResultsFileWithMissingTraits : WhenParsingTestResultFiles<NUnitResults>
    {
        public WhenParsingnUnit2ResultsFileWithMissingTraits()
            : base("NUnit2." + "results-example-nunit-missingTraits.xml")
        {
        }

        [Test]
        public void ThenCanReadFeatureResultWithoutThrowingException()
        {
            // Write out the embedded test results file
            var results = ParseResultsFile();

            var feature = new Feature { Name = "Addition" };

            Check.ThatCode(() => results.GetFeatureResult(feature)).DoesNotThrow();
        }
    }
}