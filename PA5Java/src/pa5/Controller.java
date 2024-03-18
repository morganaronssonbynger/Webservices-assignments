package pa5;

import org.tempuri.WebServicePA5SoapProxy;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.lang.reflect.Proxy;
import java.rmi.RemoteException;
import java.util.ArrayList;
import java.util.regex.Pattern;

import javax.swing.table.DefaultTableModel;

import org.tempuri.CRONUS_Sverige_AB_Employee;

import org.tempuri.WebServicePA5Soap;
import pa5.PA5Frame;

public class Controller {
	private PA5Frame frame;
	private ExceptionHandler eH;
	private WebServicePA5Soap proxy;
	private CRONUS_Sverige_AB_Employee[] empArray;
	
	// Controller constructor
	public Controller (PA5Frame frame) {
		this.frame = frame;
		proxy = new WebServicePA5SoapProxy();
		eH = new ExceptionHandler();
		populateComboboxes();
		initialize();
	}
	
	// Method to populate comboboxes
	public void populateComboboxes() {
		try {
			
		frame.getComboBoxSearch().removeAllItems();
		frame.getComboBoxRemoveNo().removeAllItems();
		frame.getComboBoxUpdateNo().removeAllItems();
		empArray = proxy.getEmployees();
		
		for(int i = 0 ; i < empArray.length ; i++) {
			String no_ = empArray[i].getNo_();
			String name = empArray[i].getFirst_Name() + " "+ empArray[i].getLast_Name();
			frame.getComboBoxSearch().addItem(no_ + " - " + name);
			frame.getComboBoxRemoveNo().addItem(no_ + " - " + name);
			frame.getComboBoxUpdateNo().addItem(no_ + " - " + name);
		}
		
		// Have to do this, otherwise update tab fills textfield or send nullpointer 
		frame.getComboBoxUpdateNo().setSelectedItem(null);
		frame.getComboBoxSearch().setSelectedItem(null);
		frame.getComboBoxRemoveNo().setSelectedItem(null);
				
		frame.getTextFieldUpdateFirstName().setText("");
		frame.getTextFieldUpdateLastName().setText("");
		frame.getTextFieldUpdateAddress().setText("");
		frame.getTextFieldUpdateJobTitle().setText("");
		
		frame.getTextAreaUpdate().setText("");

		} catch (Exception ex) {
			String errorMessage = eH.HandleException(ex);
			frame.getTextAreaSearch().setText(errorMessage);
		}
	}
	
	private void initialize() {
	
		//Search employee button
		frame.getBtnSearch().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				if(frame.getComboBoxSearch().getSelectedItem() == null) {
					frame.getTextAreaSearch().setText("Please choose an employee no before searching");
				}
				else {
					try {
						String tempNo_ = (String) frame.getComboBoxSearch().getSelectedItem();
						String no_ = Utility.SplitMethod(tempNo_);
						CRONUS_Sverige_AB_Employee emp = proxy.getEmployee(no_);
						
						frame.getTextAreaSearch().setText("Employee number: " + emp.getNo_() + "\n First name: " + emp.getFirst_Name() + "\n Last name: " + emp.getLast_Name() + "\n Address: " + emp.getAddress() + "\n Job title: " + emp.getJob_Title());
						
					}
					catch (Exception ex) {
						String errorMessage = eH.HandleException(ex);
						frame.getTextAreaSearch().setText(errorMessage);
					}
				}
			}
		});
		
		//Add employee button
		frame.getBtnAddEmployee().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(frame.getTextFieldAddFirstName().getText().isEmpty() 
					|| frame.getTextFieldAddLastName().getText().isEmpty() 
					|| frame.getTextFieldAddAddress().getText().isEmpty()
					|| frame.getTextFieldAddJobTitle().getText().isEmpty()) 
				{
					frame.getTextAreaAdd().setText("Please fill in all the required fields," + "\n First name, Last name, Address, Job title.");
				}
				else if(!frame.getTextFieldAddFirstName().getText().matches("[A-Öa-ö\\-]+") || !frame.getTextFieldAddLastName().getText().matches("([A-öa-ö]+)\\s*([A-Öa-ö]+)")) {
					frame.getTextAreaAdd().setText("Please write first and last name in the correct format which is A-ö, \n a single first name and not more than 2 last names");
				}
				else if(!frame.getTextFieldAddJobTitle().getText().matches("(^[A-öa-ö]+)\\s*([A-Öa-ö]+)\\s*([A-Öa-ö]+$)")) {
					frame.getTextAreaAdd().setText("Please write job title with letters A-ö only, and more than two letters");				
					}
				else {
					try {

						String firstName = frame.getTextFieldAddFirstName().getText();
						String lastName = frame.getTextFieldAddLastName().getText();
						String address = frame.getTextFieldAddAddress().getText();
						String jobTitle = frame.getTextFieldAddJobTitle().getText();
						
						proxy.createEmployee(firstName, lastName, address, jobTitle);
						populateComboboxes();
						
						frame.getTextAreaAdd().setText("Employee was added" + "\n First name: " + firstName + "\n Last name: " + lastName + "\n Address: " + address + "\n Job title: " + jobTitle);
						
						frame.getTextFieldAddFirstName().setText("");
						frame.getTextFieldAddLastName().setText("");
						frame.getTextFieldAddAddress().setText("");
						frame.getTextFieldAddJobTitle().setText("");
						
						
					}
					catch (Exception ex) {
						String errorMessage = eH.HandleException(ex);
						frame.getTextAreaAdd().setText(errorMessage);				
					}
				}
			}
		});
		// Remove employee button
		frame.getBtnRemove().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(frame.getComboBoxRemoveNo().getSelectedItem() == null){
					frame.getTextAreaRemove().setText("Please choose an employee no before removing.");
				}
				else {
					try {
						String tempNo_ = (String) frame.getComboBoxRemoveNo().getSelectedItem();
						String no_ = Utility.SplitMethod(tempNo_);
						
						proxy.removeEmployee(no_);
						populateComboboxes();
						frame.getTextAreaRemove().setText(tempNo_ + " was successfully removed!");
					}
					catch(Exception ex) {
						String errorMessage = eH.HandleException(ex);
						frame.getTextAreaRemove().setText(errorMessage);
					}
				}
			}
		});
		// Update employee button
		frame.getBtnUpdate().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(frame.getComboBoxUpdateNo().getSelectedItem() == null) {
					frame.getTextAreaUpdate().setText("Please choose a employee no before updating");
				}
				else if(frame.getTextFieldUpdateFirstName().getText().isEmpty() || 
						frame.getTextFieldUpdateLastName().getText().isEmpty() ||
						frame.getTextFieldUpdateAddress().getText().isEmpty() ||
						frame.getTextFieldUpdateJobTitle().getText().isEmpty()) {
					frame.getTextAreaUpdate().setText("You need to fill in all textfields," + "\n First name, Last name, Address, Job title.");
				}
				else if(!frame.getTextFieldUpdateFirstName().getText().matches("[A-Öa-ö\\-]+") || !frame.getTextFieldUpdateLastName().getText().matches("([A-öa-ö]+)\\s*([A-Öa-ö]+)")) {
					frame.getTextAreaUpdate().setText("Please write first and last name in the correct format which is A-ö, \n a single first name and not more than 2 last names");
				}
				else if(!frame.getTextFieldUpdateJobTitle().getText().matches("(^[A-öa-ö]+)\\s*([A-Öa-ö]+)\\s*([A-Öa-ö]+$)")) {
					frame.getTextAreaUpdate().setText("Please write job title with letters A-ö only, and more than two letters");
				}
				else {
					try {
						String tempNo_ = (String) frame.getComboBoxUpdateNo().getSelectedItem();
						String no_ = Utility.SplitMethod(tempNo_);
						String firstName = frame.getTextFieldUpdateFirstName().getText();
						String lastName = frame.getTextFieldUpdateLastName().getText();
						String address = frame.getTextFieldUpdateAddress().getText();
						String jobTitle = frame.getTextFieldUpdateJobTitle().getText();
						
						proxy.updateEmployee(no_, firstName, lastName, address, jobTitle);
						populateComboboxes();
						frame.getTextAreaUpdate().setText(firstName + " " + lastName + " " + address + " " + jobTitle + " was successfully Updated!");
						frame.getTextFieldUpdateFirstName().setText("");
						frame.getTextFieldUpdateLastName().setText("");
						frame.getTextFieldUpdateAddress().setText("");
						frame.getTextFieldUpdateJobTitle().setText("");
					}
					catch(Exception ex) {
						String errorMessage = eH.HandleException(ex);
						frame.getTextAreaUpdate().setText(errorMessage);
					}
				}
			}
		});
		// Populates text fields when selecting an employee in update
		frame.getComboBoxUpdateNo().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
						String tempNo = (String) frame.getComboBoxUpdateNo().getSelectedItem();
						String no_ = Utility.SplitMethod(tempNo);
						CRONUS_Sverige_AB_Employee emp = proxy.getEmployee(no_);
						String firstName = emp.getFirst_Name();
						String lastName = emp.getLast_Name();
						String address = emp.getAddress();
						String jobTitle = emp.getJob_Title();
						
						frame.getTextFieldUpdateFirstName().setText(firstName);
						frame.getTextFieldUpdateLastName().setText(lastName);
						frame.getTextFieldUpdateAddress().setText(address);
						frame.getTextFieldUpdateJobTitle().setText(jobTitle);
				}
				catch(Exception ex) {
					String errorMessage = eH.HandleException(ex);
					frame.getTextAreaUpdate().setText(errorMessage);
				}
			}
		});
	}
}
