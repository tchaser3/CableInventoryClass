/* Title:           Cable Inventory Class 
 * Date:            8-3-20
 * Author:          Terry Holmes
 * 
 * Description:     This is used for all cable transactions */

using NewEventLogDLL;
using System;
using System.Data.SqlTypes;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Security.Policy;

namespace CableInventoryDLL
{
    public class CableInventoryClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        CableWIPDataSet aCableWIPDataSet;
        CableWIPDataSetTableAdapters.cablewipTableAdapter aCableWIPTableAdapter;

        InsertCableWIPEntryTableAdapters.QueriesTableAdapter aInsertCableWIPTableAdapter;

        UpdateCableWIPFootageTableAdapters.QueriesTableAdapter aUpdateCableWIPFootageTableAdpater;

        FindCableWIPByCreateDateDataSet aFindCableWIPByCreateDateDataSet;
        FindCableWIPByCreateDateDataSetTableAdapters.FindCableWIPByCreateDateTableAdapter aFindCableWIPByCreateDateTableAdapter;

        FindCableWIPByWarehouseDataSet aFindCableWIPByWarehouseDataSet;
        FindCableWIPByWarehouseDataSetTableAdapters.FindCableWIPByWarehouseTableAdapter aFindCableWIPByWarehouseTableAdapter;

        FindCableWIPByPartWarehouseDataSet aFindCableWIPByPartWarehouseDataSet;
        FindCableWIPByPartWarehouseDataSetTableAdapters.FindCableWIPByPartWarehouseTableAdapter aFindCableWIPByPartWarehouseTableAdapter;

        CableReturnedDataSet aCableReturnedDataSet;
        CableReturnedDataSetTableAdapters.cablereturnedTableAdapter aCableReturnedTableAdapter;

        InsertReturnedCableEntryTableAdapters.QueriesTableAdapter aInsertReturnedCableTableAdapter;

        FindCableReturnedByReelIDDataSet aFindCableReturnedByReelIDDataSet;
        FindCableReturnedByReelIDDataSetTableAdapters.FindCableReturnedByReelIDTableAdapter aFindCableReturnedByReelIDTableAdapter;

        FindCableReturnedByTransactionDateDataSet aFindCableReturnedByTransactionDateDataSet;
        FindCableReturnedByTransactionDateDataSetTableAdapters.FindCableReturnedByTransactionDateTableAdapter aFindCableReturnedByTransactionDateTableAdapter;

        FindCableReturnedByEmployeeIDDataSet aFindCableReturnedByEmployeeIDDataSet;
        FindCableReturnedByEmployeeIDDataSetTableAdapters.FindCableReturnedByEmployeeIDTableAdapter aFindCableReturnedByEmployeeIDTableAdapter;

        ProjectCableUsageDataSet aProjectCableUsageDataSet;
        ProjectCableUsageDataSetTableAdapters.projectcableusageTableAdapter aProjectCableUsageTableAdapter;

        InsertProjectCableUsageEntryTableAdapters.QueriesTableAdapter aInsertProjectCableUsageTableAdapter;

        UpdateProjectCableUsageFootageEntryTableAdapters.QueriesTableAdapter aUpdateProjectCableUsageFootageTableAdapter;

        FindProjectCableUsageForProjectDataSet aFindProjectCableUsageForProjectDataSet;
        FindProjectCableUsageForProjectDataSetTableAdapters.FindProjectCableUsageForProjectTableAdapter aFindProjectCableUsageForProjectTableAdapter;

        FindProjectCableUsageByProjectPartWarehouseDataSet aFindProjectCableUsageByProjectPartWarehouseDataSet;
        FindProjectCableUsageByProjectPartWarehouseDataSetTableAdapters.FindProjectCableUsageByProjectPartWarehouseTableAdapter aFindProjectCableUsageByProjectPartWarehouseTableAdapter;

        FindProjectCableUsageByWarehouseDataSet aFindProjectCableUsageByWarehouseDataSet;
        FindProjectCableUsageByWarehouseDataSetTableAdapters.FindProjectCableUsageByWarehouseTableAdapter aFindProjectCableUsageByWarehouseTableAdapter;

        FindProjectCableUsageTotalsDataSet aFindProjectCableUsageTotalsDataSet;
        FindProjectCableUsageTotalsDataSetTableAdapters.FindProjectCableUsageTotalsTableAdapter aFindProjectCableUsageTotalsTableAdapter;

        CableTotalInventoryDataSet aCableTotalInventoryDataSet;
        CableTotalInventoryDataSetTableAdapters.cabletotalinventoryTableAdapter aCableTotalInventoryTableAdapter;

        InsertCableTotalInventoryEntryTableAdapters.QueriesTableAdapter aInsertCableTotalInventoryTableAdapter;

        UpdateCableTotalInventoryFootageEntryTableAdapters.QueriesTableAdapter aUpdateCableTotalInventoryFootageTableAdapter;

        FindCableTotalInventoryByWarehouseDataSet aFindCableTotalInventoryByWarehouseDataSet;
        FindCableTotalInventoryByWarehouseDataSetTableAdapters.FindCableTotalInventoryByWarehouseTableAdapter aFindCableTotalInventoryByWarehouseTableAdapter;

        FindCableTotalInventoryByPartWarehouseDataSet aFindCableTotalInventoryByPartWarehouseDataSet;
        FindCableTotalInventoryByPartWarehouseDataSetTableAdapters.FindCableTotalInventoryByPartWarehouseTableAdapter aFindCableTotalInventoryByPartWarehouseTableAdapter;

        FindCableTotalInventoryDataSet aFindCableTotalInventoryDataSet;
        FindCableTotalInventoryDataSetTableAdapters.FindCableTotalInventoryTableAdapter aFindCableTotalInventoryTableAdapter;

        CableReelInventoryDataSet aCableReelInventoryDataSet;
        CableReelInventoryDataSetTableAdapters.cablereelinventoryTableAdapter aCableReelInventoryTableAdapter;

        InsertCableReelInventoryEntryTableAdapters.QueriesTableAdapter aInsertCableReelInventoryTableAdapter;

        UpdateCableReelInventoryFootageEntryTableAdapters.QueriesTableAdapter aUpdateCableReelInventoryFootageTableAdapter;

        FindCableReelInventoryByPartReelWarehouseDataSet aFindCableReelInventoryByPartReelWarehouseDataSet;
        FindCableReelInventoryByPartReelWarehouseDataSetTableAdapters.FindCableReelInventoryByPartReelWarehouseTableAdapter aFindCableReelInventoryBypartReelWarehouseTableAdapter;

        FindCableReelInventoryByPartWarehouseDataSet aFindCableReelInventoryByPartWarehouseDataSet;
        FindCableReelInventoryByPartWarehouseDataSetTableAdapters.FindCableReelInventoryByPartWarehouseTableAdapter aFindCableReelInventoryByPartWarehouseTableAdapter;

        FindCableReelInventoryByWarehouseDataSet aFindCableReelInventoryByWarehouseDataSet;
        FindCableReelInventoryByWarehouseDataSetTableAdapters.FindCableReelInventoryByWarehouseTableAdapter aFindCableReelInventoryByWarehouseTableAdapter;

        CableHandCoilDataSet aCablehandCoilDataSet;
        CableHandCoilDataSetTableAdapters.cablehandcoilTableAdapter aCableHandCoilTableAdapter;

        InsertCableHandCoilEntryTableAdapters.QueriesTableAdapter aInsertCableHandCoilTableAdapter;

        RemoveCableHandCoilEntryTableAdapters.QueriesTableAdapter aRemoveCableHandCoilTableAdapter;

        UpdateCableHandCoilFootageEntryTableAdapters.QueriesTableAdapter aUpdateCableHandCoilFootageTableAdapter;

        FindCableHandCoilByCoilReelIDDataSet aFindCableHandCoilByCoilReelIDDataSet;
        FindCableHandCoilByCoilReelIDDataSetTableAdapters.FindCableHandCoilByCoilReelIDTableAdapter aFindCableHandCoilByCoilReelIDTableAdapter;

        FindCableHandCoilByPartWarehouseDataSet aFindCableHandCoilByPartWarehouseDataSet;
        FindCableHandCoilByPartWarehouseDataSetTableAdapters.FindCableHandCoilByPartWarehouseTableAdapter aFindCableHandCoilByPartWarehouseTableAdapter;

        FindCableHandCoilByWarehouseDataSet aFindCableHandCoilByWarehouseDataSet;
        FindCableHandCoilByWarehouseDataSetTableAdapters.FindCableHandCoilByWarehouseTableAdapter aFindCableHandCoilByWarehouseTableAdapter;

        FindCableHandCoilByDataEntryDateDataSet aFindCableHandCoilByDataEntryDateDataSet;
        FindCableHandCoilByDataEntryDateDataSetTableAdapters.FindCableHandCoilByDataEntryDateTableAdapter aFindCableHandCoilByDataEntryDateTableAdapter;

        CableReelIDDataSet aCableReelIDDataSet;
        CableReelIDDataSetTableAdapters.cablereelidTableAdapter aCableReelIDTableAdapter;

        InsertCableReelIDEntryTableAdapters.QueriesTableAdapter aInsertCableReelIDTableAdapter;

        FindCableReelIDByTransactionDateDataSet aFindCableReelIDByTransactionDateDataSet;
        FindCableReelIDByTransactionDateDataSetTableAdapters.FindCableReelIDByTransactionDateTableAdapter aFindCableReelIDByTransactionDateTableAdapter;

        ReceiveCableDataSet aReceiveCableDataSet;
        ReceiveCableDataSetTableAdapters.receivecableTableAdapter aReceiveCableTableAdapter;

        InsertReceiveCableEntryTableAdapters.QueriesTableAdapter aInsertReceiveCableTableAdapter;

        UpdateReceivedCableFootageEntryTableAdapters.QueriesTableAdapter aUpdateReceivedCableFootageTableAdapter;

        UpdateCableReelIDEntryTableAdapters.QueriesTableAdapter aUpdateCableReelIDTableAdapter;

        FindCableReelIDByAssignedCableIDDataSet aFindCableReelIDByAssignedCableReelIDDataSet;
        FindCableReelIDByAssignedCableIDDataSetTableAdapters.FindCableReelIDByAssignedCableReelIDTableAdapter aFindCableReelIDByAssignedCableReelIDTableAdapter;

        public FindCableReelIDByAssignedCableIDDataSet FindCableReelIDByAssignedCableReelID(string strAssignedCableReelID)
        {
            try
            {
                aFindCableReelIDByAssignedCableReelIDDataSet = new FindCableReelIDByAssignedCableIDDataSet();
                aFindCableReelIDByAssignedCableReelIDTableAdapter = new FindCableReelIDByAssignedCableIDDataSetTableAdapters.FindCableReelIDByAssignedCableReelIDTableAdapter();
                aFindCableReelIDByAssignedCableReelIDTableAdapter.Fill(aFindCableReelIDByAssignedCableReelIDDataSet.FindCableReelIDByAssignedCableReelID, strAssignedCableReelID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Find Cable Reel ID By Assigned Cable ID " + Ex.Message);
            }

            return aFindCableReelIDByAssignedCableReelIDDataSet;
        }
        public bool UpdateCableAssignedReelID(int intCableReelID, string strAssignedCableReelID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateCableReelIDTableAdapter = new UpdateCableReelIDEntryTableAdapters.QueriesTableAdapter();
                aUpdateCableReelIDTableAdapter.UpdateCableReelID(intCableReelID, strAssignedCableReelID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Assigned Cable Reel ID " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateReceivedCableFootage(int intTransactionID, int intReelFootage)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateReceivedCableFootageTableAdapter = new UpdateReceivedCableFootageEntryTableAdapters.QueriesTableAdapter();
                aUpdateReceivedCableFootageTableAdapter.UpdateReceivedCableFootage(intTransactionID, intReelFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Received Cable Footage " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertReceiveCable(DateTime datTransactionDate, int intProjectID, string strPONumber, int intWarehouseID, int intPartID, int intCableReelID, int intEmployeeID, int intReelFootage)
        {
            bool blnFatalError = false;

            try
            {
                aInsertReceiveCableTableAdapter = new InsertReceiveCableEntryTableAdapters.QueriesTableAdapter();
                aInsertReceiveCableTableAdapter.InsertReceiveCable(datTransactionDate, intProjectID, strPONumber, intWarehouseID, intPartID, intCableReelID, intEmployeeID, intReelFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Insert Receive Cable " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ReceiveCableDataSet GetReceiveCableInfo()
        {
            try
            {
                aReceiveCableDataSet = new ReceiveCableDataSet();
                aReceiveCableTableAdapter = new ReceiveCableDataSetTableAdapters.receivecableTableAdapter();
                aReceiveCableTableAdapter.Fill(aReceiveCableDataSet.receivecable);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Get Receive Cable Info " + Ex.Message);
            }

            return aReceiveCableDataSet;
        }
        public void UpdateReceiveCableDB(ReceiveCableDataSet aReceiveCableDataSet)
        {
            try
            {
                aReceiveCableTableAdapter = new ReceiveCableDataSetTableAdapters.receivecableTableAdapter();
                aReceiveCableTableAdapter.Update(aReceiveCableDataSet.receivecable);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Receive Cable DB " + Ex.Message);
            }
        }
        public FindCableReelIDByTransactionDateDataSet FindCableReelIDByTransactionDate(DateTime datTransactionDate)
        {
            try
            {
                aFindCableReelIDByTransactionDateDataSet = new FindCableReelIDByTransactionDateDataSet();
                aFindCableReelIDByTransactionDateTableAdapter = new FindCableReelIDByTransactionDateDataSetTableAdapters.FindCableReelIDByTransactionDateTableAdapter();
                aFindCableReelIDByTransactionDateTableAdapter.Fill(aFindCableReelIDByTransactionDateDataSet.FindCableReelIDByTransactionDate, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable Reel ID By Transaction Date " + Ex.Message);
            }

            return aFindCableReelIDByTransactionDateDataSet;
        }
        public bool InsertCableReelID(DateTime datTransactionDate, int intPartID, int intEmployeeID, String strAssignedCableReelID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertCableReelIDTableAdapter = new InsertCableReelIDEntryTableAdapters.QueriesTableAdapter();
                aInsertCableReelIDTableAdapter.InsertCableReelID(datTransactionDate, intPartID, intEmployeeID, strAssignedCableReelID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Insert Cable Reel Inventory " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public CableReelIDDataSet GetCableReelIDInfo()
        {
            try
            {
                aCableReelIDDataSet = new CableReelIDDataSet();
                aCableReelIDTableAdapter = new CableReelIDDataSetTableAdapters.cablereelidTableAdapter();
                aCableReelIDTableAdapter.Fill(aCableReelIDDataSet.cablereelid);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Get Cable Reel ID Info " + Ex.Message);
            }

            return aCableReelIDDataSet;
        }
        public void UpdateCableReelIDDB(CableReelIDDataSet aCableReelIDDataSet)
        {
            try
            {
                aCableReelIDTableAdapter = new CableReelIDDataSetTableAdapters.cablereelidTableAdapter();
                aCableReelIDTableAdapter.Update(aCableReelIDDataSet.cablereelid);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Cable Reel ID DB " + Ex.Message);
            }
        }
        public FindCableHandCoilByDataEntryDateDataSet FindCableHandCoilByDataEntryDate(DateTime datDataEntryDate)
        {
            try
            {
                aFindCableHandCoilByDataEntryDateDataSet = new FindCableHandCoilByDataEntryDateDataSet();
                aFindCableHandCoilByDataEntryDateTableAdapter = new FindCableHandCoilByDataEntryDateDataSetTableAdapters.FindCableHandCoilByDataEntryDateTableAdapter();
                aFindCableHandCoilByDataEntryDateTableAdapter.Fill(aFindCableHandCoilByDataEntryDateDataSet.FindCableHandCoilByDataEntryDate, datDataEntryDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable Hand Coil by Data Entry Date " + Ex.Message);
            }

            return aFindCableHandCoilByDataEntryDateDataSet;
        }
        public FindCableHandCoilByWarehouseDataSet FindCableHandCoilByWarehouse(int intWarehouseID)
        {
            try
            {
                aFindCableHandCoilByWarehouseDataSet = new FindCableHandCoilByWarehouseDataSet();
                aFindCableHandCoilByWarehouseTableAdapter = new FindCableHandCoilByWarehouseDataSetTableAdapters.FindCableHandCoilByWarehouseTableAdapter();
                aFindCableHandCoilByWarehouseTableAdapter.Fill(aFindCableHandCoilByWarehouseDataSet.FindCableHandCoilByWarehouse, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable Hand Coil By Warehouse " + Ex.Message);
            }

            return aFindCableHandCoilByWarehouseDataSet;
        }
        public FindCableHandCoilByPartWarehouseDataSet FindCableHandCoilByPartWarehouse(int intPartID, int intWarehouseID)
        {
            try
            {
                aFindCableHandCoilByPartWarehouseDataSet = new FindCableHandCoilByPartWarehouseDataSet();
                aFindCableHandCoilByPartWarehouseTableAdapter = new FindCableHandCoilByPartWarehouseDataSetTableAdapters.FindCableHandCoilByPartWarehouseTableAdapter();
                aFindCableHandCoilByPartWarehouseTableAdapter.Fill(aFindCableHandCoilByPartWarehouseDataSet.FindCableHandCoilByPartWarehouse, intPartID, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable Hand Coil By Part Warehouse " + Ex.Message);
            }

            return aFindCableHandCoilByPartWarehouseDataSet;
        }
        public FindCableHandCoilByCoilReelIDDataSet FindCableHandCoilByCoilReelID(int intCoilID)
        {
            try
            {
                aFindCableHandCoilByCoilReelIDDataSet = new FindCableHandCoilByCoilReelIDDataSet();
                aFindCableHandCoilByCoilReelIDTableAdapter = new FindCableHandCoilByCoilReelIDDataSetTableAdapters.FindCableHandCoilByCoilReelIDTableAdapter();
                aFindCableHandCoilByCoilReelIDTableAdapter.Fill(aFindCableHandCoilByCoilReelIDDataSet.FindCableHandCoilByCoilReelID, intCoilID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable Hand Coil By Coil Reel ID " + Ex.Message);
            }

            return aFindCableHandCoilByCoilReelIDDataSet;
        }
        public bool UpdateCableHandCoilFootage(int intCoilID, int intCoilFootage)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateCableHandCoilFootageTableAdapter = new UpdateCableHandCoilFootageEntryTableAdapters.QueriesTableAdapter();
                aUpdateCableHandCoilFootageTableAdapter.UpdateCableHandCoilFootage(intCoilID, intCoilFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Cable Hand Coil Footage " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool RemoveCableHandCoil(int intCoilID)
        {
            bool blnFatalError = false;

            try
            {
                aRemoveCableHandCoilTableAdapter = new RemoveCableHandCoilEntryTableAdapters.QueriesTableAdapter();
                aRemoveCableHandCoilTableAdapter.RemoveCableHandCoil(intCoilID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Remove Cable Hand Coil " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertCableHandCoil(int intCableReelID, DateTime datDataEntryDate, int intPartID, int intWarehouseID, int intCoilFootage)
        {
            bool blnFatalError = false;

            try
            {
                aInsertCableHandCoilTableAdapter = new InsertCableHandCoilEntryTableAdapters.QueriesTableAdapter();
                aInsertCableHandCoilTableAdapter.InsertCableHandCoil(intCableReelID, datDataEntryDate, intPartID, intWarehouseID, intCoilFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Insert Cable Hand Coil " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public CableHandCoilDataSet GetCableHandCoilInfo()
        {
            try
            {
                aCablehandCoilDataSet = new CableHandCoilDataSet();
                aCableHandCoilTableAdapter = new CableHandCoilDataSetTableAdapters.cablehandcoilTableAdapter();
                aCableHandCoilTableAdapter.Fill(aCablehandCoilDataSet.cablehandcoil);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Get Cable Hand Coil Info " + Ex.Message);
            }

            return aCablehandCoilDataSet;
        }
        public void UpdateCableHandCoilDB(CableHandCoilDataSet aCablehandCoilDataSet)
        {
            try
            {
                aCableHandCoilTableAdapter = new CableHandCoilDataSetTableAdapters.cablehandcoilTableAdapter();
                aCableHandCoilTableAdapter.Update(aCablehandCoilDataSet.cablehandcoil);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Cable Hand Coil DB " + Ex.Message);
            }
        }
        public FindCableReelInventoryByWarehouseDataSet FindCableReelInventoryByWarehouse(int intWarehouseID)
        {
            try
            {
                aFindCableReelInventoryByWarehouseDataSet = new FindCableReelInventoryByWarehouseDataSet();
                aFindCableReelInventoryByWarehouseTableAdapter = new FindCableReelInventoryByWarehouseDataSetTableAdapters.FindCableReelInventoryByWarehouseTableAdapter();
                aFindCableReelInventoryByWarehouseTableAdapter.Fill(aFindCableReelInventoryByWarehouseDataSet.FindCableReelInventoryByWarehouse, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable Reel Inventory By Warehouse " + Ex.Message);
            }

            return aFindCableReelInventoryByWarehouseDataSet;
        }
        public FindCableReelInventoryByPartWarehouseDataSet FindCableReelInventoryByPartWarehouse(int intPartID, int intWarehouseID)
        {
            try
            {
                aFindCableReelInventoryByPartWarehouseDataSet = new FindCableReelInventoryByPartWarehouseDataSet();
                aFindCableReelInventoryByPartWarehouseTableAdapter = new FindCableReelInventoryByPartWarehouseDataSetTableAdapters.FindCableReelInventoryByPartWarehouseTableAdapter();
                aFindCableReelInventoryByPartWarehouseTableAdapter.Fill(aFindCableReelInventoryByPartWarehouseDataSet.FindCableReelInventoryByPartWarehouse, intPartID, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Reel Inventory // Find Cable Reel Inventory By Part Warehouse " + Ex.Message);
            }

            return aFindCableReelInventoryByPartWarehouseDataSet;
        }
        public FindCableReelInventoryByPartReelWarehouseDataSet FindCableReelInventoryByPartReelWarehouse(int intPartID, string strReelID, int intWarehouseID)
        {
            try
            {
                aFindCableReelInventoryByPartReelWarehouseDataSet = new FindCableReelInventoryByPartReelWarehouseDataSet();
                aFindCableReelInventoryBypartReelWarehouseTableAdapter = new FindCableReelInventoryByPartReelWarehouseDataSetTableAdapters.FindCableReelInventoryByPartReelWarehouseTableAdapter();
                aFindCableReelInventoryBypartReelWarehouseTableAdapter.Fill(aFindCableReelInventoryByPartReelWarehouseDataSet.FindCableReelInventoryByPartReelWarehouse, intPartID, strReelID, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable Reel Inventory By Part Reel Warehouse " + Ex.Message);
            }

            return aFindCableReelInventoryByPartReelWarehouseDataSet;
        }
        public bool UpdateCableReelInventoryFootage(int intTransactionID, int intReelFootage)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateCableReelInventoryFootageTableAdapter = new UpdateCableReelInventoryFootageEntryTableAdapters.QueriesTableAdapter();
                aUpdateCableReelInventoryFootageTableAdapter.UpdateCableReelInventoryFootage(intTransactionID, intReelFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Cable Reel Inventory Footage " + Ex.Message);
            }

            return blnFatalError;
        }
        public bool InsertCableReelInventory(int intPartID, int intWarehouseID, string strReelID, int intReelFootage)
        {
            bool blnFatalError = true;

            try
            {
                aInsertCableReelInventoryTableAdapter = new InsertCableReelInventoryEntryTableAdapters.QueriesTableAdapter();
                aInsertCableReelInventoryTableAdapter.InsertCableReelInventory(intPartID, intWarehouseID, strReelID, intReelFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Insert Cable Reel Inventory " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public CableReelInventoryDataSet GetCableReelInventoryInfo()
        {
            try
            {
                aCableReelInventoryDataSet = new CableReelInventoryDataSet();
                aCableReelInventoryTableAdapter = new CableReelInventoryDataSetTableAdapters.cablereelinventoryTableAdapter();
                aCableReelInventoryTableAdapter.Fill(aCableReelInventoryDataSet.cablereelinventory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Get Cable Reel Inventory Info " + Ex.Message);
            }

            return aCableReelInventoryDataSet;
        }
        public void UpdateCableReelInventoryDB(CableReelInventoryDataSet aCableReelInventoryDataSet)
        {
            try
            {
                aCableReelInventoryTableAdapter = new CableReelInventoryDataSetTableAdapters.cablereelinventoryTableAdapter();
                aCableReelInventoryTableAdapter.Update(aCableReelInventoryDataSet.cablereelinventory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Cable Reel Inventory DB " + Ex.Message);
            }
        }
        public FindCableTotalInventoryDataSet FindCableTotalInventory()
        {
            try
            {
                aFindCableTotalInventoryDataSet = new FindCableTotalInventoryDataSet();
                aFindCableTotalInventoryTableAdapter = new FindCableTotalInventoryDataSetTableAdapters.FindCableTotalInventoryTableAdapter();
                aFindCableTotalInventoryTableAdapter.Fill(aFindCableTotalInventoryDataSet.FindCableTotalInventory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable Total Inventory " + Ex.Message);
            }                

            return aFindCableTotalInventoryDataSet;
        }
        public FindCableTotalInventoryByPartWarehouseDataSet FindCableTotalInventoryByPartWarehouse(int intWarehouseID, int intPartID)
        {
            try
            {
                aFindCableTotalInventoryByPartWarehouseDataSet = new FindCableTotalInventoryByPartWarehouseDataSet();
                aFindCableTotalInventoryByPartWarehouseTableAdapter = new FindCableTotalInventoryByPartWarehouseDataSetTableAdapters.FindCableTotalInventoryByPartWarehouseTableAdapter();
                aFindCableTotalInventoryByPartWarehouseTableAdapter.Fill(aFindCableTotalInventoryByPartWarehouseDataSet.FindCableTotalInventoryByPartWarehouse, intWarehouseID, intPartID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable Total Inventory By Part Warehouse " + Ex.Message);
            }

            return aFindCableTotalInventoryByPartWarehouseDataSet;
        }
        public FindCableTotalInventoryByWarehouseDataSet FindCableTotalInventoryByWarehouse(int intWarehouseID)
        {
            try
            {
                aFindCableTotalInventoryByWarehouseDataSet = new FindCableTotalInventoryByWarehouseDataSet();
                aFindCableTotalInventoryByWarehouseTableAdapter = new FindCableTotalInventoryByWarehouseDataSetTableAdapters.FindCableTotalInventoryByWarehouseTableAdapter();
                aFindCableTotalInventoryByWarehouseTableAdapter.Fill(aFindCableTotalInventoryByWarehouseDataSet.FindCableTotalInventoryByWarehouse, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable Total Inventory By Warehouse " + Ex.Message);
            }

            return aFindCableTotalInventoryByWarehouseDataSet;
        }
        public bool UpdateCableIventoryTotalFootage(int intTransactionID, int intTotalFootage)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateCableTotalInventoryFootageTableAdapter = new UpdateCableTotalInventoryFootageEntryTableAdapters.QueriesTableAdapter();
                aUpdateCableTotalInventoryFootageTableAdapter.UpdateCableTotalInventoryFootage(intTransactionID, intTotalFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Cable Inventory Total Footage " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertCableTotalInventory(int intPartID, int intWarehouseID, int intTotalFootage)
        {
            bool blnFatalError = false;

            try
            {
                aInsertCableTotalInventoryTableAdapter = new InsertCableTotalInventoryEntryTableAdapters.QueriesTableAdapter();
                aInsertCableTotalInventoryTableAdapter.InsertCableTotalInventory(intPartID, intWarehouseID, intTotalFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Insert Cable Total Inventory " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public CableTotalInventoryDataSet GetCableTotalInventoryInfo()
        {
            try
            {
                aCableTotalInventoryDataSet = new CableTotalInventoryDataSet();
                aCableTotalInventoryTableAdapter = new CableTotalInventoryDataSetTableAdapters.cabletotalinventoryTableAdapter();
                aCableTotalInventoryTableAdapter.Fill(aCableTotalInventoryDataSet.cabletotalinventory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Get Cable Total Inventory Info " + Ex.Message);
            }

            return aCableTotalInventoryDataSet;
        }
        public void UpdateCableTotalInventoryDB(CableTotalInventoryDataSet aCableTotalInventoryDataSet)
        {
            try
            {
                aCableTotalInventoryTableAdapter = new CableTotalInventoryDataSetTableAdapters.cabletotalinventoryTableAdapter();
                aCableTotalInventoryTableAdapter.Update(aCableTotalInventoryDataSet.cabletotalinventory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Cable Total Inventory DB " + Ex.Message);
            }
        }
        public FindProjectCableUsageTotalsDataSet FindProjectCableUsageTotals(int intProjectID)
        {
            try
            {
                aFindProjectCableUsageTotalsDataSet = new FindProjectCableUsageTotalsDataSet();
                aFindProjectCableUsageTotalsTableAdapter = new FindProjectCableUsageTotalsDataSetTableAdapters.FindProjectCableUsageTotalsTableAdapter();
                aFindProjectCableUsageTotalsTableAdapter.Fill(aFindProjectCableUsageTotalsDataSet.FindProjectCableUsageTotals, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Project Cable Usage Totals " + Ex.Message);
            }

            return aFindProjectCableUsageTotalsDataSet;
        }
        public FindProjectCableUsageByWarehouseDataSet FindProjectCableUsageByWarehouse(int intWarehouseID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindProjectCableUsageByWarehouseDataSet = new FindProjectCableUsageByWarehouseDataSet();
                aFindProjectCableUsageByWarehouseTableAdapter = new FindProjectCableUsageByWarehouseDataSetTableAdapters.FindProjectCableUsageByWarehouseTableAdapter();
                aFindProjectCableUsageByWarehouseTableAdapter.Fill(aFindProjectCableUsageByWarehouseDataSet.FindProjectCableUsageByWarehouse, intWarehouseID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Project Cable Usage By Warehouse " + Ex.Message);
            }

            return aFindProjectCableUsageByWarehouseDataSet;
        }
        public FindProjectCableUsageByProjectPartWarehouseDataSet FindProjectCableUsageByProjectPartWarehouse(int intProjectID, int intPartID, int intWarehouseID)
        {
            try
            {
                aFindProjectCableUsageByProjectPartWarehouseDataSet = new FindProjectCableUsageByProjectPartWarehouseDataSet();
                aFindProjectCableUsageByProjectPartWarehouseTableAdapter = new FindProjectCableUsageByProjectPartWarehouseDataSetTableAdapters.FindProjectCableUsageByProjectPartWarehouseTableAdapter();
                aFindProjectCableUsageByProjectPartWarehouseTableAdapter.Fill(aFindProjectCableUsageByProjectPartWarehouseDataSet.FindProjectCableUsageByProjectPartWarehouse, intProjectID, intPartID, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Project Cable Usage By Project Part Warehouse " + Ex.Message);
            }

            return aFindProjectCableUsageByProjectPartWarehouseDataSet;
        }
        public FindProjectCableUsageForProjectDataSet FindProjectCableUsageForProject(int intProjectID)
        {
            try
            {
                aFindProjectCableUsageForProjectDataSet = new FindProjectCableUsageForProjectDataSet();
                aFindProjectCableUsageForProjectTableAdapter = new FindProjectCableUsageForProjectDataSetTableAdapters.FindProjectCableUsageForProjectTableAdapter();
                aFindProjectCableUsageForProjectTableAdapter.Fill(aFindProjectCableUsageForProjectDataSet.FindProjectCableUsageForProject, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Project Cable Usage For Project " + Ex.Message);
            }

            return aFindProjectCableUsageForProjectDataSet;
        }
        public bool UpdateProjectCableUsageFootage(int intTransactionID, int intFootageUsage)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProjectCableUsageFootageTableAdapter = new UpdateProjectCableUsageFootageEntryTableAdapters.QueriesTableAdapter();
                aUpdateProjectCableUsageFootageTableAdapter.UpdateProjectCableUsageFootage(intTransactionID, intFootageUsage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Project Cable Usage Footage " + Ex.Message);
            }

            return blnFatalError;
        }
        public bool InsertProjectCableUsage(DateTime datTransactionDate, int intProjectID, int intPartID, int intCableReelID, int intWarehouseID, int intWarehouseEmployeeID, int intFootageUsed)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProjectCableUsageTableAdapter = new InsertProjectCableUsageEntryTableAdapters.QueriesTableAdapter();
                aInsertProjectCableUsageTableAdapter.InsertProjectCableUsage(datTransactionDate, intProjectID, intPartID, intCableReelID, intWarehouseID, intWarehouseEmployeeID, intFootageUsed);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Insert Project Cable Usage " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProjectCableUsageDataSet GetProjectCableUsageInfo()
        {
            try
            {
                aProjectCableUsageDataSet = new ProjectCableUsageDataSet();
                aProjectCableUsageTableAdapter = new ProjectCableUsageDataSetTableAdapters.projectcableusageTableAdapter();
                aProjectCableUsageTableAdapter.Fill(aProjectCableUsageDataSet.projectcableusage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Get Project Cable Usage Info " + Ex.Message);
            }

            return aProjectCableUsageDataSet;
        }
        public void UpdateProjectCableUsageDB(ProjectCableUsageDataSet aProjectCableUsageDataSet)
        {
            try
            {
                aProjectCableUsageTableAdapter = new ProjectCableUsageDataSetTableAdapters.projectcableusageTableAdapter();
                aProjectCableUsageTableAdapter.Update(aProjectCableUsageDataSet.projectcableusage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Project Cable Usage DB " + Ex.Message);
            }
        }
        public FindCableReturnedByEmployeeIDDataSet FindCableReturnedByEmployeeID(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindCableReturnedByEmployeeIDDataSet = new FindCableReturnedByEmployeeIDDataSet();
                aFindCableReturnedByEmployeeIDTableAdapter = new FindCableReturnedByEmployeeIDDataSetTableAdapters.FindCableReturnedByEmployeeIDTableAdapter();
                aFindCableReturnedByEmployeeIDTableAdapter.Fill(aFindCableReturnedByEmployeeIDDataSet.FindCableReturnedByEmployeeID, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable Returned By Employee ID " + Ex.Message);
            }

            return aFindCableReturnedByEmployeeIDDataSet;
        }
        public FindCableReturnedByTransactionDateDataSet FindCableReturnedByTransactionDate(DateTime datTransactionDate)
        {
            try
            {
                aFindCableReturnedByTransactionDateDataSet = new FindCableReturnedByTransactionDateDataSet();
                aFindCableReturnedByTransactionDateTableAdapter = new FindCableReturnedByTransactionDateDataSetTableAdapters.FindCableReturnedByTransactionDateTableAdapter();
                aFindCableReturnedByTransactionDateTableAdapter.Fill(aFindCableReturnedByTransactionDateDataSet.FindCableReturnedByTransactionDate, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable Returned By Transaction Date " + Ex.Message);
            }

            return aFindCableReturnedByTransactionDateDataSet;
        }
        public FindCableReturnedByReelIDDataSet FindCableReturnedByReelID(string strReelID, int intPartID, int intWarehouseID)
        {
            try
            {
                aFindCableReturnedByReelIDDataSet = new FindCableReturnedByReelIDDataSet();
                aFindCableReturnedByReelIDTableAdapter = new FindCableReturnedByReelIDDataSetTableAdapters.FindCableReturnedByReelIDTableAdapter();
                aFindCableReturnedByReelIDTableAdapter.Fill(aFindCableReturnedByReelIDDataSet.FindCableReturnedByReelID, strReelID, intPartID, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable Returned By Reel ID " + Ex.Message);
            }

            return aFindCableReturnedByReelIDDataSet;
        }
        public bool InsertReturnedCable(DateTime datTransactionDate, string strReelID, int intPartID, int intWarehouseID, int intEmployeeID, int intWarehouseEmployeeID, int intReturnedFootage)
        {
            bool blnFatalError = false;

            try
            {
                aInsertReturnedCableTableAdapter = new InsertReturnedCableEntryTableAdapters.QueriesTableAdapter();
                aInsertReturnedCableTableAdapter.InsertReturnedCable(datTransactionDate, strReelID, intPartID, intWarehouseID, intEmployeeID, intWarehouseEmployeeID, intReturnedFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Insert Returned Cable " + Ex.Message);
            }

            return blnFatalError;
        }
        public CableReturnedDataSet GetCableReturnedInfo()
        {
            try
            {
                aCableReturnedDataSet = new CableReturnedDataSet();
                aCableReturnedTableAdapter = new CableReturnedDataSetTableAdapters.cablereturnedTableAdapter();
                aCableReturnedTableAdapter.Fill(aCableReturnedDataSet.cablereturned);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Get Cable Returned Info " + Ex.Message);
            }

            return aCableReturnedDataSet;
        }
        public  void UpdateCableReturnedDB(CableReturnedDataSet aCableReturnedDataSet)
        {
            try
            {
                aCableReturnedTableAdapter = new CableReturnedDataSetTableAdapters.cablereturnedTableAdapter();
                aCableReturnedTableAdapter.Update(aCableReturnedDataSet.cablereturned);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Get Cable Returned Info " + Ex.Message);
            }
        }
        public FindCableWIPByPartWarehouseDataSet FindCableWIPByPartWarehouse(int intPartID, int intWarehouseID)
        {
            try
            {
                aFindCableWIPByPartWarehouseDataSet = new FindCableWIPByPartWarehouseDataSet();
                aFindCableWIPByPartWarehouseTableAdapter = new FindCableWIPByPartWarehouseDataSetTableAdapters.FindCableWIPByPartWarehouseTableAdapter();
                aFindCableWIPByPartWarehouseTableAdapter.Fill(aFindCableWIPByPartWarehouseDataSet.FindCableWIPByPartWarehouse, intPartID, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable WIP By Part Warehouse " + Ex.Message);
            }

            return aFindCableWIPByPartWarehouseDataSet;
        }
        public FindCableWIPByWarehouseDataSet FindCableWIPByWarehouse(int intWarehouseID)
        {
            try
            {
                aFindCableWIPByWarehouseDataSet = new FindCableWIPByWarehouseDataSet();
                aFindCableWIPByWarehouseTableAdapter = new FindCableWIPByWarehouseDataSetTableAdapters.FindCableWIPByWarehouseTableAdapter();
                aFindCableWIPByWarehouseTableAdapter.Fill(aFindCableWIPByWarehouseDataSet.FindCableWIPByWarehouse, intWarehouseID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable WIP By Warehouse " + Ex.Message);
            }

            return aFindCableWIPByWarehouseDataSet;
        }
        public FindCableWIPByCreateDateDataSet FindCableWIPByCreateDate(DateTime datCreateDate)
        {
            try
            {
                aFindCableWIPByCreateDateDataSet = new FindCableWIPByCreateDateDataSet();
                aFindCableWIPByCreateDateTableAdapter = new FindCableWIPByCreateDateDataSetTableAdapters.FindCableWIPByCreateDateTableAdapter();
                aFindCableWIPByCreateDateTableAdapter.Fill(aFindCableWIPByCreateDateDataSet.FindCableWIPByCreateDate, datCreateDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Find Cable WIP By Create Date " + Ex.Message);
            }

            return aFindCableWIPByCreateDateDataSet;
        }
        public bool UpdateCableWIPFootage(int intTransactionID, int intTotalFootage)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateCableWIPFootageTableAdpater = new UpdateCableWIPFootageTableAdapters.QueriesTableAdapter();
                aUpdateCableWIPFootageTableAdpater.UpdateCableWIPFootage(intTransactionID, intTotalFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Cable WIP Footage " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertCableWIP(int intPartID, int intWarehouseID, int intTotalFootage, DateTime datCreateDate, int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertCableWIPTableAdapter = new InsertCableWIPEntryTableAdapters.QueriesTableAdapter();
                aInsertCableWIPTableAdapter.InsertCableWIP(intPartID, intWarehouseID, intTotalFootage, datCreateDate, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Insert Cable WIP " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public CableWIPDataSet GetCableWIPInfo()
        {
            try
            {
                aCableWIPDataSet = new CableWIPDataSet();
                aCableWIPTableAdapter = new CableWIPDataSetTableAdapters.cablewipTableAdapter();
                aCableWIPTableAdapter.Fill(aCableWIPDataSet.cablewip);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Get Cable WIP Info " + Ex.Message);
            }

            return aCableWIPDataSet;
        }
        public void UpdateCableWIPDB(CableWIPDataSet aCableWIPDataSet)
        {
            try
            {
                aCableWIPTableAdapter = new CableWIPDataSetTableAdapters.cablewipTableAdapter();
                aCableWIPTableAdapter.Update(aCableWIPDataSet.cablewip);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Cable Inventory Class // Update Cable WIP DB " + Ex.Message);
            }
        }
    }
}
