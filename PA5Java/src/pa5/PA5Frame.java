package pa5;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTabbedPane;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JRadioButton;
import javax.swing.JComboBox;
import javax.swing.JButton;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.JLabel;
import java.awt.Label;
import java.awt.Font;

public class PA5Frame extends JFrame {

	private JPanel contentPane;
	private JComboBox comboBoxSearch;
	private JTextArea textAreaSearch;
	private JButton btnSearch;
	private JButton btnAddEmployee;
	private JTextField textFieldAddFirstName;
	private JTextField textFieldAddLastName;
	private JTextField textFieldAddAddress;
	private JTextField textFieldAddJobTitle;
	private JTextArea textAreaAdd;
	private JComboBox comboBoxRemoveNo;
	private JButton btnRemove;
	private JTextArea textAreaRemove;
	private JTextField textFieldUpdateFirstName;
	private JTextField textFieldUpdateLastName;
	private JTextField textFieldUpdateAddress;
	private JTextField textFieldUpdateJobTitle;
	private JTextField textFieldRemoveFirstName;
	private JTextField textFieldRemoveLastName;
	private JTextField textFieldRemoveAddress;
	private JTextField textFieldRemoveJobTitle;
	private JButton btnUpdate;
	private JComboBox comboBoxUpdateNo;
	private JTextArea textAreaUpdate;
	
	public JTextArea getTextAreaUpdate() {
		return textAreaUpdate;
	}

	public void setTextAreaUpdate(JTextArea textAreaUpdate) {
		this.textAreaUpdate = textAreaUpdate;
	}

	public JComboBox getComboBoxUpdateNo() {
		return comboBoxUpdateNo;
	}

	public void setComboBoxUpdateNo(JComboBox comboBoxUpdateNo) {
		this.comboBoxUpdateNo = comboBoxUpdateNo;
	}
	
	public JTextField getTextFieldUpdateFirstName() {
		return textFieldUpdateFirstName;
	}

	public void setTextFieldUpdateFirstName(JTextField textFieldUpdateFirstName) {
		this.textFieldUpdateFirstName = textFieldUpdateFirstName;
	}

	public JTextField getTextFieldUpdateLastName() {
		return textFieldUpdateLastName;
	}

	public void setTextFieldUpdateLastName(JTextField textFieldUpdateLastName) {
		this.textFieldUpdateLastName = textFieldUpdateLastName;
	}

	public JTextField getTextFieldUpdateAddress() {
		return textFieldUpdateAddress;
	}

	public void setTextFieldUpdateAddress(JTextField textFieldUpdateAddress) {
		this.textFieldUpdateAddress = textFieldUpdateAddress;
	}

	public JTextField getTextFieldUpdateJobTitle() {
		return textFieldUpdateJobTitle;
	}

	public void setTextFieldUpdateJobTitle(JTextField textFieldUpdateJobTitle) {
		this.textFieldUpdateJobTitle = textFieldUpdateJobTitle;
	}

	public JButton getBtnUpdate() {
		return btnUpdate;
	}

	public void setBtnUpdate(JButton btnUpdate) {
		this.btnUpdate = btnUpdate;
	}
	
	public JTextArea getTextAreaRemove() {
		return textAreaRemove;
	}

	public void setTextAreaRemove(JTextArea textAreaRemove) {
		this.textAreaRemove = textAreaRemove;
	}

	public JButton getBtnRemove() {
		return btnRemove;
	}

	public void setBtnRemove(JButton btn_Remove) {
		this.btnRemove = btn_Remove;
	}

	public JComboBox getComboBoxRemoveNo() {
		return comboBoxRemoveNo;
	}

	public void setComboBoxRemoveNo(JComboBox comboBoxRemoveNo) {
		this.comboBoxRemoveNo = comboBoxRemoveNo;
	}
	
	public JTextArea getTextAreaAdd() {
		return textAreaAdd;
	}

	public void setTextAreaAdd(JTextArea textAreaAdd) {
		this.textAreaAdd = textAreaAdd;
	}

	public JTextField getTextFieldAddFirstName() {
		return textFieldAddFirstName;
	}

	public void setTextFieldAddFirstName(JTextField textFieldAddFirstName) {
		this.textFieldAddFirstName = textFieldAddFirstName;
	}

	public JTextField getTextFieldAddLastName() {
		return textFieldAddLastName;
	}

	public void setTextFieldAddLastName(JTextField textFieldAddLastName) {
		this.textFieldAddLastName = textFieldAddLastName;
	}

	public JTextField getTextFieldAddAddress() {
		return textFieldAddAddress;
	}

	public void setTextFieldAddAddress(JTextField textFieldAddAddress) {
		this.textFieldAddAddress = textFieldAddAddress;
	}

	public JTextField getTextFieldAddJobTitle() {
		return textFieldAddJobTitle;
	}

	public void setTextFieldAddJobTitle(JTextField textFieldAddJobTitle) {
		this.textFieldAddJobTitle = textFieldAddJobTitle;
	}
	

	public JButton getBtnAddEmployee() {
		return btnAddEmployee;
	}

	public void setBtnAddEmployee(JButton btnAddEmployee) {
		this.btnAddEmployee = btnAddEmployee;
	}
	
	public JButton getBtnSearch() {
		return btnSearch;
	}

	public void setBtnSearch(JButton btnSearch) {
		this.btnSearch = btnSearch;
	}

	public JTextArea getTextAreaSearch() {
		return textAreaSearch;
	}

	public void setTextAreaSearch(JTextArea textAreaSearch) {
		this.textAreaSearch = textAreaSearch;
	}

	public JComboBox getComboBoxSearch() {
		return comboBoxSearch;
	}

	public void setComboBoxSearch(JComboBox comboBoxSearch) {
		this.comboBoxSearch = comboBoxSearch;
	}

	/**
	 * Create the frame.
	 */
	public PA5Frame() {
		setTitle("Employee application");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 716, 464);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JTabbedPane tabbedPane = new JTabbedPane(JTabbedPane.TOP);
		tabbedPane.setBounds(0, 0, 700, 425);
		contentPane.add(tabbedPane);
		
		JPanel panelSearch = new JPanel();
		tabbedPane.addTab("Search", null, panelSearch, null);
		panelSearch.setLayout(null);
		
		comboBoxSearch = new JComboBox();
		comboBoxSearch.setBounds(98, 73, 151, 19);
		panelSearch.add(comboBoxSearch);
		
		btnSearch = new JButton("Search");
		btnSearch.setBounds(122, 138, 89, 23);
		panelSearch.add(btnSearch);
		
		textAreaSearch = new JTextArea();
		textAreaSearch.setEditable(false);
		textAreaSearch.setBounds(272, 70, 372, 217);
		panelSearch.add(textAreaSearch);
		
		JLabel labelSearchNo = new JLabel("No:*");
		labelSearchNo.setFont(new Font("Tahoma", Font.PLAIN, 13));
		labelSearchNo.setBounds(35, 75, 32, 14);
		panelSearch.add(labelSearchNo);
		
		JPanel panelAdd = new JPanel();
		tabbedPane.addTab("Create", null, panelAdd, null);
		panelAdd.setLayout(null);
		
		textAreaAdd = new JTextArea();
		textAreaAdd.setEditable(false);
		textAreaAdd.setBounds(272, 70, 372, 217);
		panelAdd.add(textAreaAdd);
		
		textFieldAddFirstName = new JTextField();
		textFieldAddFirstName.setBounds(98, 73, 151, 19);
		panelAdd.add(textFieldAddFirstName);
		textFieldAddFirstName.setColumns(10);
		
		textFieldAddLastName = new JTextField();
		textFieldAddLastName.setColumns(10);
		textFieldAddLastName.setBounds(98, 116, 151, 19);
		panelAdd.add(textFieldAddLastName);
		
		textFieldAddAddress = new JTextField();
		textFieldAddAddress.setColumns(10);
		textFieldAddAddress.setBounds(98, 157, 151, 19);
		panelAdd.add(textFieldAddAddress);
		
		textFieldAddJobTitle = new JTextField();
		textFieldAddJobTitle.setColumns(10);
		textFieldAddJobTitle.setBounds(98, 199, 151, 19);
		panelAdd.add(textFieldAddJobTitle);
		
		btnAddEmployee = new JButton("Add");
		btnAddEmployee.setBounds(116, 264, 103, 23);
		panelAdd.add(btnAddEmployee);
		
		Label labelAddFirstName = new Label("First Name:*");
		labelAddFirstName.setBounds(10, 70, 82, 22);
		panelAdd.add(labelAddFirstName);
		
		Label labelAddLastName = new Label("Last Name:*");
		labelAddLastName.setBounds(10, 116, 82, 22);
		panelAdd.add(labelAddLastName);
		
		Label labelAddAddress = new Label("Address:*");
		labelAddAddress.setBounds(10, 154, 82, 22);
		panelAdd.add(labelAddAddress);
		
		Label labelAddJobTitle = new Label("Job Title:*");
		labelAddJobTitle.setBounds(10, 199, 82, 22);
		panelAdd.add(labelAddJobTitle);
		
		JPanel panelUpdate = new JPanel();
		tabbedPane.addTab("Update", null, panelUpdate, null);
		panelUpdate.setLayout(null);
		
		textFieldUpdateFirstName = new JTextField();
		textFieldUpdateFirstName.setBounds(98, 116, 151, 19);
		panelUpdate.add(textFieldUpdateFirstName);
		textFieldUpdateFirstName.setColumns(10);
		
		textFieldUpdateLastName = new JTextField();
		textFieldUpdateLastName.setBounds(98, 157, 151, 19);
		panelUpdate.add(textFieldUpdateLastName);
		textFieldUpdateLastName.setColumns(10);
		
		textFieldUpdateAddress = new JTextField();
		textFieldUpdateAddress.setBounds(98, 199, 151, 19);
		panelUpdate.add(textFieldUpdateAddress);
		textFieldUpdateAddress.setColumns(10);
		
		textFieldUpdateJobTitle = new JTextField();
		textFieldUpdateJobTitle.setBounds(98, 238, 151, 19);
		panelUpdate.add(textFieldUpdateJobTitle);
		textFieldUpdateJobTitle.setColumns(10);
		
		textAreaUpdate = new JTextArea();
		textAreaUpdate.setEditable(false);
		textAreaUpdate.setBounds(272, 70, 372, 217);
		panelUpdate.add(textAreaUpdate);
		
		btnUpdate = new JButton("Update");
		btnUpdate.setBounds(126, 264, 89, 23);
		panelUpdate.add(btnUpdate);
		
		Label labelUpdateFirstName = new Label("First Name:*");
		labelUpdateFirstName.setBounds(10, 113, 74, 22);
		panelUpdate.add(labelUpdateFirstName);
		
		Label labelUpdateLastName = new Label("Last Name:*");
		labelUpdateLastName.setBounds(13, 154, 79, 22);
		panelUpdate.add(labelUpdateLastName);
		
		Label labelUpdateAddress = new Label("Address:*");
		labelUpdateAddress.setBounds(18, 196, 74, 22);
		panelUpdate.add(labelUpdateAddress);
		
		Label labelUpdateJobTitle = new Label("Job Title:*");
		labelUpdateJobTitle.setBounds(18, 235, 74, 22);
		panelUpdate.add(labelUpdateJobTitle);
		
		comboBoxUpdateNo = new JComboBox();
		comboBoxUpdateNo.setBounds(98, 73, 151, 19);
		panelUpdate.add(comboBoxUpdateNo);
		
		Label labelUpdateNo = new Label("No_:*");
		labelUpdateNo.setBounds(22, 70, 62, 22);
		panelUpdate.add(labelUpdateNo);
		
		JPanel panelRemove = new JPanel();
		tabbedPane.addTab("Remove", null, panelRemove, null);
		panelRemove.setLayout(null);
		
		comboBoxRemoveNo = new JComboBox();
		comboBoxRemoveNo.setBounds(98, 73, 151, 19);
		panelRemove.add(comboBoxRemoveNo);
		
		JLabel labelRemoveNo = new JLabel("No_:*");
		labelRemoveNo.setFont(new Font("Tahoma", Font.PLAIN, 13));
		labelRemoveNo.setBounds(26, 74, 37, 14);
		panelRemove.add(labelRemoveNo);
		
		textAreaRemove = new JTextArea();
		textAreaRemove.setEditable(false);
		textAreaRemove.setBounds(272, 70, 372, 217);
		panelRemove.add(textAreaRemove);
		
		btnRemove = new JButton("Remove");
		btnRemove.setBounds(122, 138, 84, 23);
		panelRemove.add(btnRemove);
	}
}
