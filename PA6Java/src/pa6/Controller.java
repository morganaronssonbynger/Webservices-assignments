package pa6;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;
import java.util.ArrayList;

import javax.swing.table.DefaultTableModel;

import org.tempuri.WebServicePA6Soap;
import org.tempuri.WebServicePA6SoapProxy;

public class Controller {

	private PA6Frame frame;
	private WebServicePA6Soap proxy;
	private ExceptionHandler eH;
	
	// Controller constructor
	public Controller(PA6Frame frame) {
		this.frame = frame;
		proxy = new WebServicePA6SoapProxy();
		eH = new ExceptionHandler();
		initialize();
				
	}
	
	private void initialize() {
		
		// Fills combobox 
		ArrayList<String> optionsList = new ArrayList<String>();
		optionsList.add("Employees and relatives");
		optionsList.add("Employees who were sick 2004");
		optionsList.add("Employee with most abscense");
		optionsList.add("Employee columns 1");
		optionsList.add("Employee columns 2");
		optionsList.add("All Tables 1");
		optionsList.add("All Tables 2");
		optionsList.add("Table constraints");
		optionsList.add("Indexes");
		optionsList.add("Key constraints");
		optionsList.add("Metadata");
		
		
		for(String str : optionsList) {
			frame.getComboBoxOptions().addItem(str);
		}
		
		frame.getComboBoxOptions().setSelectedItem(null);
		
		// Populates JTable depending on which index is selected in the combobox
		frame.getComboBoxOptions().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			try {
				
				//ComboBox index 0 is Employees and Relatives
				if(frame.getComboBoxOptions().getSelectedIndex() == 0) {
					String[][] employeeAndRelativeList = proxy.getEmployeesAndRelatives();
					String[] columnNameList = new String[] { "No", "First name","Last name", "Address", "Job Title", "Relative code","Relatives First name", "Relatives Last Name"};

					//https://1bestcsharp.blogspot.com/2018/01/java-populate-jtable-from-Multidimensional-Array.html
					DefaultTableModel tableModel = (DefaultTableModel)frame.getTable().getModel();
					tableModel.setDataVector(employeeAndRelativeList, columnNameList);
				}
				
				//ComboBox index 1 is Employees who where sick 2004
				else if(frame.getComboBoxOptions().getSelectedIndex() == 1) {
					String[][] employeeWhoWhereSick2004List = proxy.getEmployeesWhoWhereSick2004();
					String [] columnNameList = new String[] { "No_ ", "First Name", "Last Name", "Address", "Job Title" };
					
					DefaultTableModel tableModel = (DefaultTableModel)frame.getTable().getModel();
					tableModel.setDataVector(employeeWhoWhereSick2004List, columnNameList);
				}
				
				//ComboBox index 2 is Employee with most absence
				else if(frame.getComboBoxOptions().getSelectedIndex() == 2) {
					String[][] employeeWithMostAbsenceList = proxy.getEmployeesWithMostAbscense();
					String [] columnNameList = new String[] { "First Name" };
					
					DefaultTableModel tableModel = (DefaultTableModel)frame.getTable().getModel();
					tableModel.setDataVector(employeeWithMostAbsenceList, columnNameList);
				}
				
				//ComboBox index 3 is one version to get Employee columns
				else if(frame.getComboBoxOptions().getSelectedIndex() == 3) {
					String[][] employeeColumnsList = proxy.getEmployeeColumnsOne();
					String[] columnNameList = new String[] { "Column name"};
			
					DefaultTableModel tableModel = (DefaultTableModel)frame.getTable().getModel();
					tableModel.setDataVector(employeeColumnsList, columnNameList);
				}
				
				//ComboBox index 4 is another version to get Employee columns
				else if(frame.getComboBoxOptions().getSelectedIndex() == 4) {
					String[][] employeeColumnList = proxy.getEmployeeColumnsTwo();
					String [] columnNameList = new String[] { "Column name" };
					
					DefaultTableModel tableModel = (DefaultTableModel)frame.getTable().getModel();
					tableModel.setDataVector(employeeColumnList, columnNameList);
				}
				
				//ComboBox index 5 is one version to get all tables
				else if(frame.getComboBoxOptions().getSelectedIndex() == 5) {
					String[][] tablesList = proxy.getTablesMethodOne();
					String [] columnNameList = new String[] { "Table name" };
					
					DefaultTableModel tableModel = (DefaultTableModel)frame.getTable().getModel();
					tableModel.setDataVector(tablesList, columnNameList);
				}
				
				//ComboBox index 6 is another version to get all tables
				else if(frame.getComboBoxOptions().getSelectedIndex() == 6) {
					String[][] tablesList = proxy.getTablesMethodTwo();
					String [] columnNameList = new String[] { "Table name" };
					
					DefaultTableModel tableModel = (DefaultTableModel)frame.getTable().getModel();
					tableModel.setDataVector(tablesList, columnNameList);
				}
				
				//ComboBox index 7 is table constraints
				else if(frame.getComboBoxOptions().getSelectedIndex() == 7) {
					String[][] tableConstraintsList = proxy.getTableConstraints();
					String [] columnNameList = new String[] { "Constraint name", "Table name", "Constraint type" };
					
					DefaultTableModel tableModel = (DefaultTableModel)frame.getTable().getModel();
					tableModel.setDataVector(tableConstraintsList, columnNameList);
				}
				
				//ComboBox index 8 is indexes
				else if(frame.getComboBoxOptions().getSelectedIndex() == 8) {
					String[][] indexesList = proxy.getIndexes();
					String [] columnNameList = new String[] { "Object id", "Name", "Index id", "Type" };
					
					DefaultTableModel tableModel = (DefaultTableModel)frame.getTable().getModel();
					tableModel.setDataVector(indexesList, columnNameList);
				}
				
				//ComboBox index 9 is key constraints
				else if(frame.getComboBoxOptions().getSelectedIndex() == 9) {
					String[][] keyConstraintsList = proxy.getKeyConstraints();
					String [] columnNameList = new String[] { "Name", "Type" };
					
					DefaultTableModel tableModel = (DefaultTableModel)frame.getTable().getModel();
					tableModel.setDataVector(keyConstraintsList, columnNameList);
				}
				
				//ComboBox index 10 is metadata from all employee related tables
				else if(frame.getComboBoxOptions().getSelectedIndex() == 10) {
					String[][] metadataList = proxy.getMetaDataFromEmployeeTable();
					String [] columnNameList = new String[] { "Name", "Object id", "Type", "Type desc" };
					
					DefaultTableModel tableModel = (DefaultTableModel)frame.getTable().getModel();
					tableModel.setDataVector(metadataList, columnNameList);
				}
								
			}
			catch (Exception ex) {
				String errorMessage = eH.HandleException(ex);
				frame.getTextAreaErrorDialog().setText(errorMessage);
			}
			}
		});
	}
}
