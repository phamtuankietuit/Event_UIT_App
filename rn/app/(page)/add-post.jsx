import React, { useState } from "react"
import {
  View,
  Text,
  ScrollView,
  StyleSheet,
  TouchableOpacity,
  FlatList,
  Image,
  TextInput,
  Switch,
  Modal,
} from "react-native"
import { SafeAreaView } from "react-native-safe-area-context"
import { AntDesign } from "@expo/vector-icons"
import { Ionicons } from "@expo/vector-icons"
import * as ImagePicker from "expo-image-picker"
import { useSelector, useDispatch } from "react-redux"
import { addImages, removeImage, setPostContent } from "../redux/postSlice"
import { StatusBar } from "expo-status-bar"
import TextEditor from "../components/textEditor"
import DateTimePicker from "react-native-ui-datepicker"
import dayjs from "dayjs"
import { FontAwesome } from "@expo/vector-icons"

const training = require("../../assets/images/training.png")
const workshop = require("../../assets/images/workshop.png")
const seminar = require("../../assets/images/seminar.png")
const webinar = require("../../assets/images/webinar.png")
const conference = require("../../assets/images/conference.png")
const other = require("../../assets/images/other.jpg")

const styles = StyleSheet.create({
  image: {
    width: 60,
    height: 60,
    borderRadius: 5,
  },
  deleteButton: {
    position: "absolute",
    top: -5,
    right: -5,
    backgroundColor: "rgba(0, 0, 0, 0.6)",
    borderRadius: 10,
    padding: 2,
  },
  flatListContainer: {
    padding: 10,
    flexDirection: "row",
  },
})

const AddPost = () => {
  const dispatch = useDispatch()

  const [selectedEventType, setSelectedEventType] = useState(null)

  const handleEventTypeSelection = (type) => {
    setSelectedEventType(type)
  }

  const toggleSwitch = () => setIsEnabled((previousState) => !previousState)
  const [isEnabled, setIsEnabled] = useState(false)

  const selectedImages = useSelector((state) => state.post.selectedImages)
  const postContent = useSelector((state) => state.post.postContent)

  const [number, setNumber] = useState(0)

  const [startDate, setStartDate] = useState(dayjs())
  const [endDate, setEndDate] = useState(dayjs())

  const [startDateText, setStartDateText] = useState("Chọn ngày bắt đầu")
  const [endDateText, setEndDateText] = useState("Chọn ngày kết thúc")

  const [showStartDatePicker, setShowStartDatePicker] = useState(false)
  const [showEndDatePicker, setShowEndDatePicker] = useState(false)

  const [visibleTypeModal, setVisibleTypeModa] = useState(false)

  //chọn loại skien
  const handleChooseType = () => {
    setVisibleTypeModa(false)
  }

  // Function to toggle DateTimePicker modal
  const toggleStartDatePicker = () => {
    if (showEndDatePicker !== true) {
      setShowStartDatePicker(!showStartDatePicker)
    } else {
      setShowEndDatePicker(!showEndDatePicker)
      setShowStartDatePicker(!showStartDatePicker)
    }
  }

  const toggleEndDatePicker = () => {
    if (showStartDatePicker !== true) {
      setShowEndDatePicker(!showEndDatePicker)
    } else {
      setShowStartDatePicker(!showStartDatePicker)
      setShowEndDatePicker(!showEndDatePicker)
    }
  }

  const pickImage = async () => {
    if (selectedImages.length >= 5) return
    let result = await ImagePicker.launchImageLibraryAsync({
      mediaTypes: ImagePicker.MediaTypeOptions.Images,
      allowsMultipleSelection: true,
      selectionLimit: 5 - selectedImages.length,
      quality: 1,
    })

    if (!result.canceled) {
      const selectedAssets = result.assets.map((asset) => asset.uri)
      dispatch(addImages(selectedAssets))
    }
  }

  const isCreateButtonEnabled =
    selectedImages.length > 0 && postContent.length > 0

  const deleteImage = (uri) => {
    dispatch(removeImage(uri))
  }

  return (
    <SafeAreaView className='flex-1 bg-slate-100'>
      <StatusBar></StatusBar>
      <View className='flex-1'>
        <View
          className='h-[46] w-full flex-row items-center justify-between px-2'
          style={{ borderBottomWidth: 0.7, borderColor: "#cdcdcd" }}
        >
          <View className='flex-row items-center'>
            <TouchableOpacity>
              <AntDesign name='left' size={15} color='#6F6A61' />
            </TouchableOpacity>
            <Text
              className='ml-2 font-semibold'
              style={{ fontSize: 15, color: "#6F6A61" }}
            >
              Tạo bài đăng
            </Text>
          </View>
          <View>
            <TouchableOpacity
              className={`rounded p-2 ${isCreateButtonEnabled ? "bg-blue-600" : "bg-gray-400"}`}
              disabled={!isCreateButtonEnabled}
            >
              <Text
                style={{ color: isCreateButtonEnabled ? "white" : "black" }}
              >
                TẠO MỚI
              </Text>
            </TouchableOpacity>
          </View>
        </View>
        {/* Nội dung bài đăng */}
        <ScrollView className='flex-1' showsVerticalScrollIndicator={false}>
          {/* nội dung bài */}
          <View className='flex-1 justify-center px-3 py-2'>
            <TextInput
              placeholder='Nhập tiêu đề bài đăng...'
              placeholderTextColor={"#888"}
              className='mb-2 rounded bg-white py-3 pl-[9] text-base'
              style={{
                shadowColor: "#000000",
                shadowOffset: {
                  width: 0,
                  height: 3,
                },
                shadowOpacity: 0.17,
                shadowRadius: 3.05,
                elevation: 4,
              }}
              multiline
              onChangeText={(text) => dispatch(setPostContent(text))}
            ></TextInput>
            {/* mô tả */}
            <TextEditor></TextEditor>
            {/* địa điểm */}
            <TextInput
              placeholder='Nhập địa điểm tổ chức...'
              placeholderTextColor={"#888"}
              className='mt-2 rounded bg-white py-3 pl-[9] text-base'
              style={{
                shadowColor: "#000000",
                shadowOffset: {
                  width: 0,
                  height: 3,
                },
                shadowOpacity: 0.17,
                shadowRadius: 3.05,
                elevation: 4,
              }}
              multiline
              onChangeText={(text) => dispatch(setPostContent(text))}
            ></TextInput>
            {/* daypicker */}
            <View
              className='mt-2 rounded bg-white px-[9] py-3'
              style={{
                shadowColor: "#000000",
                shadowOffset: {
                  width: 0,
                  height: 3,
                },
                shadowOpacity: 0.17,
                shadowRadius: 3.05,
                elevation: 4,
              }}
            >
              <View className='flex-row items-center justify-between'>
                <Text className='text-base text-sky-600'>{startDateText}</Text>
                <TouchableOpacity onPress={toggleStartDatePicker}>
                  <FontAwesome name='calendar-o' size={24} color='#0284C7' />
                </TouchableOpacity>
              </View>
            </View>
            {/* end date */}
            <View
              className='mt-2 rounded bg-white px-[9] py-3'
              style={{
                shadowColor: "#000000",
                shadowOffset: {
                  width: 0,
                  height: 3,
                },
                shadowOpacity: 0.17,
                shadowRadius: 3.05,
                elevation: 4,
              }}
            >
              <View className='flex-row items-center justify-between'>
                <Text className='text-base text-sky-600'>{endDateText}</Text>
                <TouchableOpacity onPress={toggleEndDatePicker}>
                  <FontAwesome name='calendar-o' size={24} color='#0284C7' />
                </TouchableOpacity>
              </View>
            </View>
            {/* is published */}
            <View
              className='mt-2 flex-row items-center justify-between rounded bg-white pl-[9]'
              style={{
                shadowColor: "#000000",
                shadowOffset: {
                  width: 0,
                  height: 3,
                },
                shadowOpacity: 0.17,
                shadowRadius: 3.05,
                elevation: 4,
              }}
            >
              <Text className='text-base text-sky-600'>Công bố sự kiện</Text>
              <Switch
                trackColor={{ false: "#767577", true: "#81b0ff" }}
                thumbColor={isEnabled ? "#0284C7" : "#f4f3f4"}
                ios_backgroundColor='#3e3e3e'
                onValueChange={toggleSwitch}
                value={isEnabled}
              />
            </View>
            {/* loại sự kiện */}
            <TouchableOpacity
              className='mt-2 flex-row items-center justify-between rounded bg-white px-[9] py-3'
              style={{
                shadowColor: "#000000",
                shadowOffset: {
                  width: 0,
                  height: 3,
                },
                shadowOpacity: 0.17,
                shadowRadius: 3.05,
                elevation: 4,
              }}
              onPress={() => setVisibleTypeModa(true)}
            >
              <View className='flex-row '>
                <Text className='text-base text-sky-600'>Loại sự kiện:</Text>
                <Text className='text-base text-slate-600'>
                  {" "}
                  {selectedEventType}
                </Text>
              </View>

              <AntDesign name='arrowright' size={24} color='#0284C7' />
            </TouchableOpacity>
            {/* số lượng tham gia */}
            <View
              className='mt-2 flex-row items-center justify-between rounded bg-white px-[9] py-2'
              style={{
                shadowColor: "#000000",
                shadowOffset: {
                  width: 0,
                  height: 3,
                },
                shadowOpacity: 0.17,
                shadowRadius: 3.05,
                elevation: 4,
              }}
            >
              <Text className='text-base text-sky-600'>
                Số lượng tham gia tối đa:
              </Text>
              <TextInput
                className=' w-[60] rounded-sm border border-sky-600 pr-[5] text-right text-base text-sky-600'
                keyboardType='nummeric'
              >
                {number}
              </TextInput>
            </View>
            {/* link */}
            <TextInput
              placeholder='Nhập link form tham gia...'
              placeholderTextColor={"#888"}
              className='mt-2 rounded bg-white py-3 pl-[9] text-base'
              style={{
                shadowColor: "#000000",
                shadowOffset: {
                  width: 0,
                  height: 3,
                },
                shadowOpacity: 0.17,
                shadowRadius: 3.05,
                elevation: 4,
              }}
              multiline
              onChangeText={(text) => dispatch(setPostContent(text))}
            ></TextInput>
          </View>
        </ScrollView>
        <View className='absolute bottom-0'>
          <FlatList
            data={selectedImages}
            horizontal
            keyExtractor={(item) => item}
            contentContainerStyle={styles.flatListContainer}
            renderItem={({ item }) => (
              <View className='relative mr-2'>
                <Image
                  source={{ uri: item }}
                  className='h-[60] w-[60] rounded-lg'
                />
                <TouchableOpacity
                  style={styles.deleteButton}
                  onPress={() => deleteImage(item)}
                >
                  <AntDesign name='close' size={15} color='white' />
                </TouchableOpacity>
              </View>
            )}
          />
        </View>
        {showStartDatePicker && (
          <View className='bg-white pb-8'>
            <DateTimePicker
              date={startDate}
              mode='single'
              onChange={(params) => {
                setStartDate(params.date)
                setStartDateText(params.date.toString())
              }}
              timePicker={true}
              selectedItemColor='#0284C7'
              headerButtonColor='#0284C7'
              headerContainerStyle={{
                backgroundColor: "#fff",
                borderBottomWidth: 0.5,
                borderColor: "#cdcdcd",
                borderTopWidth: 0.5,
              }}
              headerTextStyle={{ color: "#0284C7" }}
            />
          </View>
        )}
        {showEndDatePicker && (
          <View className='bg-white pb-8'>
            <DateTimePicker
              date={endDate}
              mode='single'
              onChange={(params) => {
                setEndDate(params.date)
                setEndDateText(params.date.toString())
              }}
              timePicker={true}
              selectedItemColor='#0284C7'
              headerButtonColor='#0284C7'
              headerContainerStyle={{
                backgroundColor: "#fff",
                borderBottomWidth: 0.5,
                borderColor: "#cdcdcd",
                borderTopWidth: 0.5,
              }}
              headerTextStyle={{ color: "#0284C7" }}
            />
          </View>
        )}
        <View className='absolute bottom-3 right-2'>
          <TouchableOpacity
            onPress={pickImage}
            className='h-[55] w-[55] items-center justify-center rounded-full bg-blue-600'
          >
            <Ionicons name='image' size={30} color='white' />
          </TouchableOpacity>
        </View>
      </View>
      <Modal
        transparent={true}
        visible={visibleTypeModal}
        animationType='slide'
        onRequestClose={() => setVisibleTypeModa(false)}
      >
        <View
          className='flex-1 items-center justify-center '
          style={{ backgroundColor: "rgba(0, 0, 0, 0.5)" }}
        >
          <View className=' items-center rounded-lg bg-white px-12 pb-5 pt-2'>
            <Text className='mb-4 text-base text-sky-600'>
              Chọn loại sự kiện
            </Text>
            <View className='flex-row gap-2'>
              <TouchableOpacity
                className='items-center'
                onPress={() => handleEventTypeSelection("Training")}
              >
                <View
                  className={`h-[60] w-[60] items-center justify-center rounded-lg border-4 ${selectedEventType === "Training" ? "border-blue-600" : "border-slate-500"} `}
                >
                  <Image
                    source={training}
                    className=' h-[50] w-[50] rounded-sm'
                  ></Image>
                </View>
                <Text
                  className={`text-base ${
                    selectedEventType === "Training"
                      ? "text-blue-600"
                      : "text-slate-500"
                  }`}
                >
                  {" "}
                  Training
                </Text>
              </TouchableOpacity>
              <TouchableOpacity
                className='items-center'
                onPress={() => handleEventTypeSelection("Workshop")}
              >
                <View
                  className={`h-[60] w-[60] items-center justify-center rounded-lg border-4 ${selectedEventType === "Workshop" ? "border-blue-600" : "border-slate-500"} `}
                >
                  <Image
                    source={workshop}
                    className=' h-[50] w-[50] rounded-sm'
                  ></Image>
                </View>
                <Text
                  className={`text-base ${
                    selectedEventType === "Workshop"
                      ? "text-blue-600"
                      : "text-slate-500"
                  }`}
                >
                  {" "}
                  Workshop
                </Text>
              </TouchableOpacity>
              <TouchableOpacity
                className='items-center'
                onPress={() => handleEventTypeSelection("Seminar")}
              >
                <View
                  className={`h-[60] w-[60] items-center justify-center rounded-lg border-4 ${selectedEventType === "Seminar" ? "border-blue-600" : "border-slate-500"} `}
                >
                  <Image
                    source={seminar}
                    className=' h-[50] w-[50] rounded-sm'
                  ></Image>
                </View>
                <Text
                  className={`text-base ${
                    selectedEventType === "Seminar"
                      ? "text-blue-600"
                      : "text-slate-500"
                  }`}
                >
                  {" "}
                  Seminar
                </Text>
              </TouchableOpacity>
            </View>
            <View className='flex-row gap-1'>
              <TouchableOpacity
                className='items-center'
                onPress={() => handleEventTypeSelection("Webinar")}
              >
                <View
                  className={`h-[60] w-[60] items-center justify-center rounded-lg border-4 ${selectedEventType === "Webinar" ? "border-blue-600" : "border-slate-500"} `}
                >
                  <Image
                    source={webinar}
                    className=' h-[50] w-[50] rounded-sm'
                  ></Image>
                </View>
                <Text
                  className={`text-base ${
                    selectedEventType === "Webinar"
                      ? "text-blue-600"
                      : "text-slate-500"
                  }`}
                >
                  {" "}
                  Webinar
                </Text>
              </TouchableOpacity>
              <TouchableOpacity
                className='items-center'
                onPress={() => handleEventTypeSelection("Conference")}
              >
                <View
                  className={`h-[60] w-[60] items-center justify-center rounded-lg border-4 ${selectedEventType === "Conference" ? "border-blue-600" : "border-slate-500"} `}
                >
                  <Image
                    source={conference}
                    className=' h-[50] w-[50] rounded-sm'
                  ></Image>
                </View>
                <Text
                  className={`text-base ${
                    selectedEventType === "Conference"
                      ? "text-blue-600"
                      : "text-slate-500"
                  }`}
                >
                  {" "}
                  Conference
                </Text>
              </TouchableOpacity>
              <TouchableOpacity
                className='items-center'
                onPress={() => handleEventTypeSelection("Other")}
              >
                <View
                  className={`h-[60] w-[60] items-center justify-center rounded-lg border-4 ${selectedEventType === "Other" ? "border-blue-600" : "border-slate-500"} `}
                >
                  <Image source={other} className=' h-[50] w-[50] rounded-sm' />
                </View>
                <Text
                  className={`text-base ${
                    selectedEventType === "Other"
                      ? "text-blue-600"
                      : "text-slate-500"
                  }`}
                >
                  {" "}
                  Other
                </Text>
              </TouchableOpacity>
            </View>
            <TouchableOpacity onPress={() => handleChooseType()}>
              <Text className='mt-2 text-base text-black'>Đóng</Text>
            </TouchableOpacity>
          </View>
        </View>
      </Modal>
    </SafeAreaView>
  )
}

export default AddPost
